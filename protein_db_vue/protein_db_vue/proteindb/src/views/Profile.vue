<template>
  <div class="profile">
  <div class=screen>

    <div class=main-content>
        <div class=profile-info>
            <div class=profile-img >
                <img src="../assets/images/profile.jpg" alt="">
            </div>
            <div class=info-container>
                <h1>{{currentUser.name}}</h1>
                <div class=info-uni>
                    <i class="fas fa-university"></i> <b> University: </b> {{currentUser.university}}
                </div>
                <div class=info-job>
                    <i class="fas fa-user-tie"></i> <b> Job:</b> {{currentUser.job}}
                </div>
                <div class=description>
                    <i class="far fa-file-alt"></i> <b>Description:</b>  {{currentUser.description}}
                </div>
                <div class=profile-edit>
                    <button type="button" class="btn btn-primary blue-button"><i class="fas fa-pencil-alt"></i> Edit</button>
                </div>
            </div>
        </div>


        <div class=nav-button-row>
            <button @click="state='Projects'" type="button" class="btn btn-primary blue-button myactive">Project</button>
            <button @click="state='Questions'" type="button" class="btn btn-primary blue-button">Questions</button>
            <button @click="state='Answers'" type="button" class="btn btn-primary blue-button">Answers</button>
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
            <br>
            <br>

                <div class="prev-next">
                  <button type="button" class="btn btn-primary blue-button side-edit-btn"><i class="fas fa-arrow-right"></i></button>
                  <button type="button" class="btn btn-primary blue-button side-edit-btn"><i class="fas fa-arrow-left"></i></button>
                </div>
        </div>
    </div>
    </div>
  </div>
</template>

<script>
// @ is an alias to /src

import {mapState} from 'vuex'
import projRes from '@/components/projRes.vue'
import answerRes from '@/components/answerRes.vue'

export default {
  name: 'profile',
  components: {
      projRes,
      answerRes
  },

   data() {
      return {
          currentUser:{},
          filter:'',
          state: 'Projects',
      }
    },


    methods:{
        onChange(event){
            if(event.target.value=="Recent"){
                this.projects= this.projects.sort(function(item1,item2){
                    var parts1 =item1. creationDate.split('-');
                    var parts2 =item2. creationDate.split('-');
                    var mydate1 = new Date(parts1[2], parts1[1], parts1[0]); 
                    var mydate2 = new Date(parts2[2], parts2[1], parts2[0]); 
                    return mydate2-mydate1;
                })
            }
        }
    },

    computed:{
    ...mapState([
        'users',
        'projects',
        'questions'
    ]),
    /*
    currentUser: function(){
        return this.users.find(function(user){
            return user.id==$route.params.id;
        })
    }*/


    filteredProj: function(){
        


        let myfilter= this.filter.toLowerCase();
       return this.projects.filter(function(project){
           let projName=project.name.toLowerCase();
            return projName.includes(myfilter)
        })
    },

    filteredAnswers: function(){

         let listQuestions=this.questions;

        let myfilter= this.filter.toLowerCase();
        let id=0;
        let myAnswersList=[];
        for(var questionN in listQuestions){
            let question=listQuestions[questionN];
            for(var answerN in question.answers){
                 let answer= question.answers[answerN];
              
                if(answer.author=="Frederico"){
                    answer['question']=question.title;
                    answer['id']=id;
                    myAnswersList.push(answer);
                    id++;
               }
            }
        }
       
       return myAnswersList.filter(function(answer){
           let answerF=answer.question.toLowerCase();
            return answerF.includes(myfilter)
        })
    },


    filteredQuestions: function(){
        let myfilter= this.filter.toLowerCase();

        

       
        return myAnswersList.filter(function(answer){
            let answerF=answer.question.toLowerCase();
            return answerF.includes(myfilter)
        })
    }


    },

    mounted() {
        this.currentUser=this['users'][this.$route.params.id];
    }


}
</script>

<style>
 @import '../assets/css/profile.css';
</style>

