<template>
  <div class="profile">
  <div class="screen">

    <div class="main-content">
        <div class=profile-info style="color: gray">
            <div class=profile-img >
                <img src="../assets/images/profile.jpg" alt="">
            </div>
            <div class=info-container>
                <h1>{{currentUser.name}}</h1>
                <div class=info-uni>
                    <i class="fas fa-university" style="color: black"></i> <b style="color: black"> University: </b> {{currentUser.university}}
                </div>
                <div class=info-job>
                    <i class="fas fa-user-tie" style="color: black"></i> <b style="color: black"> Job:</b> {{currentUser.job}}
                </div>
                <div class=description>
                    <i class="far fa-file-alt" style="color: black"></i> <b style="color: black"> Description:</b>  {{currentUser.description}}
                </div>
                <div class=profile-edit>
                    <button type="button" class="btn btn-primary add-button"><i class="fas fa-pencil-alt"></i> Edit</button>
                </div>
            </div>
        </div>

        <div class=nav-button-row>
            <button  style="background-color: #00B4CC; color: white" ref="Projects" @click="state='Projects'; clearRefs($event)" type="button" class="btn ">Project</button>
            <button style="background-color: #00B4CC; color: white" ref="Questions" @click="state='Questions'; clearRefs($event)" type="button" class="btn">Questions</button>
            <!--<button ref="Answers" @click="state='Answers'; clearRefs($event)" type="button" class="btn btn-primary blue-button">Answers</button>-->
          <button style="background-color: #00B4CC; color: white" ref="Answers" @click="state='Answers'; clearRefs($event)" type="button" class="btn">Answers</button>
        </div>

        <div class=filter-row>
                <select @change="onChange($event)">
                        <option value="Recent" >Recent</option>
                        <option value="Older">Older</option>
                </select>
                <input v-model="filter" type="text" name="Search" placeholder="Search"><br>
        </div>

        <div class=result-list>
             <div v-if="state==='Projects'">
                <div v-for="project in filteredProj" v-bind:key="project.id">
                        <projRes
                        :project=project
                        />
                </div>
            </div>
            <div v-else-if="state==='Answers'">
                <div v-for="answer in filteredAnswers" v-bind:key="answer.id">

                    <answerRes
                        :answer=answer
                    />
                </div>
            </div>

            <div v-else>

                <div class="questions container home-question-ans-profile" style="max-width:2400px;margin-top: 20px!important;" v-for="(question,index) in filteredQuestions" v-bind:key="index">
                    <!--<div style="margin: 10px">-->
                      <questionPrevProfile
                          :question=question
                      />
                    <!--</div>-->
                </div>
              <br>
            </div>
            <br>
            <br>

          <div class="container" style="padding-top: 1%; padding-bottom: 7%">
            <div class="row">
              <div class="col-sm-10">
              </div>
              <div class="col-sm-1">
                <div v-on:click="next()">
                  <button style="background-color: #00B4CC; color: white" type="button" class="btn round  side-edit-btn"><i class="fas fa-arrow-left"></i></button>
                </div>
              </div>
              <div class="col-sm-1">
                <div v-on:click="prev()">
                  <button style="background-color: #00B4CC; color: white" type="button" class="btn round side-edit-btn"><i class="fas fa-arrow-right"></i></button>
                </div>
              </div>
            </div>
          </div>
        </div>
    </div>
    </div>
  </div>
</template>

<script>
// @ is an alias to /src

import { mapState, mapGetters } from 'vuex'
import projRes from '@/components/projRes.vue'
import answerRes from '@/components/answerRes.vue'
import questionPrevProfile from '@/components/questionPrevProfile.vue'

export default {
  name: 'profile',
  components: {
    projRes,
    answerRes,
    questionPrevProfile
  },

  data () {
    return {
      currentUser: {},
      filter: '',
      state: 'Projects'
    }
  },

  methods: {
    onChange (event) {
      if (event.target.value == 'Recent') {
        this.projects = this.projects.sort(function (item1, item2) {
          var parts1 = item1.creationDate.split('-')
          var parts2 = item2.creationDate.split('-')
          var mydate1 = new Date(parts1[2], parts1[1], parts1[0])
          var mydate2 = new Date(parts2[2], parts2[1], parts2[0])
          return mydate2 - mydate1
        })
      }
    },

    clearRefs (event) {
      // console.log()
      this.$refs['Projects'].classList.remove('myactive')
      this.$refs['Answers'].classList.remove('myactive')
      this.$refs['Questions'].classList.remove('myactive')
      event.target.classList.add('myactive')
    }

  },

  computed: {
    ...mapState([
      'users',
      'projects',
      'questions'
    ]),

    ...mapGetters([
      'getUserQuestions'
    ]),

    listOfQuestions: function () {
      return this.getUserQuestions('Frederico')
    },
    /*
    currentUser: function(){
        return this.users.find(function(user){
            return user.id==$route.params.id;
        })
    } */

    filteredProj: function () {
      let myfilter = this.filter.toLowerCase()
      return this.projects.filter(function (project) {
        let projName = project.name.toLowerCase()
        return projName.includes(myfilter)
      })
    },

    filteredAnswers: function () {
      let listQuestions = this.questions

      let myfilter = this.filter.toLowerCase()
      let id = 0
      let myAnswersList = []
      for (var questionN in listQuestions) {
        let question = listQuestions[questionN]
        for (var answerN in question.answers) {
          let answer = question.answers[answerN]

          if (answer.author == 'Frederico') {
            answer['question'] = question.title
            answer['id'] = id
            myAnswersList.push(answer)
            id++
          }
        }
      }

      return myAnswersList.filter(function (answer) {
        let answerF = answer.question.toLowerCase()
        return answerF.includes(myfilter)
      })
    },

    filteredQuestions: function () {
      let myfilter = this.filter.toLowerCase()

      return this.listOfQuestions.filter(function (question) {
        let questF = question.title.toLowerCase()
        return questF.includes(myfilter)
      })
    }

  },

  mounted () {
    this.currentUser = this['users'][this.$route.params.id]
  }

}
</script>

<style>
 @import '../assets/css/profile.css';

.questions{
    display:flex;
    align-items:center;
}
 .questions > *{
     margin:0% !important;
     width:auto !important;
     height:auto !important;
 }

</style>
