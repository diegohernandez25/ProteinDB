<template>
  <div class="home">
    <!--Question section-->

    <div class="container" style="padding-top: 10px; padding-left: 3%">
        <div class="ask">
            <div class="row">
                <div class="col-sm-1 hide-item">
                    <img src="../assets/images/avatar.png" alt="Avatar" class="avatar">
                </div>
                <div class="col-sm-11">
                    <router-link class="avatar-name" :to="`/profile/0`">Frederico</router-link>
                    <br>
                    <span class="avatar-workplace">University of Aveiro - Biology Master Degree</span>
                </div>

            </div>

            <div class="row"  style="padding-left: 5%; padding-top: 3%">
                <input v-model="questionForm.title"  type="text" class="question-text" placeholder="Ask a Question!">
            </div>
            <hr style="border-top: 1px solid;">
            <div class="row" style="padding-left: 5%; padding-top: 3%">
                <!--<input  v-model="questionForm.body" type="text" class="question-text" placeholder="Explain more details about your question.">-->
                <textarea v-model="questionForm.body" class="form-control write-answer" id="exampleFormControlTextarea3" placeholder="Write details of your question" rows="7"
                        style="border: none"></textarea>
                <b-alert v-model="showDismissibleAlert" variant="danger" dismissible>
            You can't submit an empty question!
            </b-alert>
            </div>
            <div class="row" style="padding-left: 5%; padding-top: 3%">
                <div class="col-sm-9">
                    <input type="text" class="tag-text" placeholder="➕ add tag" style="width: 12%">
                </div>
                <div class="col-sm-3">

                    <button @click="submitNewQuestion();" type="submit" class="submit-question">
                        Submit
                    </button>
                </div>
            </div>
        </div>
    </div>
    <br>

    <!--Tabs section-->

    <div class='container tabs-section'>
      <b-tabs content-class="mt-3">
        <b-tab @click="tabIndex=0; resetIndex()" title="Most Viewed" active>
          <div id='Most_Viewed_Questions' class="tab-content padding-grey-area">

             <div v-for="(question,index) in orderedQuestionsByViews.slice(index, index+3)" v-bind:key="index" class=question >
              <Question
              :question="question"
              />
            </div>
          </div>
        </b-tab>
        <b-tab @click="tabIndex=1; resetIndex()" title="Not Answered">
          <div id='Not_Answered' class="tab-content">
           <div v-for="(question,index) in nonAnswerdQuestions.slice(index, index+3)" v-bind:key="index" class=question >
              <Question
              :question="question"
              />
            </div>
          </div>
        </b-tab>
        <b-tab @click="tabIndex=1; resetIndex()" title="My Questions">
          <div id='My_Questions' class="tab-content">
            <div v-for="(question, index) in getMyQuestions('Frederico')" v-bind:key="index" class=question >
              <Question
                :question="question"
              />
            </div>
          </div>
        </b-tab>
        <div class="container" style="padding-top: 1%; ">
          <div class="row">
            <div class="col-sm-9">
            </div>
            <div class="col-sm-1" >
              <button v-on:click="next()" style="padding-right:30px; background-color: #00B4CC; color: white" type="button" class="btn round  side-edit-btn"><i class="fas fa-arrow-left"></i></button>
            </div>
            <div class="col-sm-1 label-text" style="text-align: center; " >
              <span style="text-align: center; margin: 50%;" class="label-text"><h2>1</h2></span>
            </div>
            <div class="col-sm-1" >
              <button  v-on:click="prev()" style="background-color: #00B4CC; color: white; " type="button" class="btn round side-edit-btn"><i class="fas fa-arrow-right"></i></button>
            </div>
          </div>
        </div>
     </b-tabs>
    </div>

  </div>
</template>

<script>
// @ is an alias to /src
import Question from '@/components/questionPrev.vue'

import { mapState, mapActions, mapGetters } from 'vuex'

export default {
  name: 'home',
  components: {
    Question
  },

  data () {
    return {
      fields: ['title'],
      index: 0,
      tabIndex: 0,
      questionForm: {
        title: '',
        body: '',
        author: 'Frederico',
        answers: [],
        date: '01-01-2019',
        views: 0,
        answeredStatus: -1
      },
      showDismissibleAlert: false
    }
  },

  methods: {
    ...mapActions([
      'addQuestion'
    ]),
    ...mapGetters([
      'getIDbyQuestion'
    ]),

    next: function () {
      if (this.tabIndex == 0) {
        if (this.orderedQuestionsByViews.length > this.index + 3) {
          this.index += 3
        }
      } else {
        if (this.nonAnswerdQuestions.length > this.index + 3) {
          this.index += 3
        }
      }
    },

    prev: function () {
      if (this.index > 0) {
        this.index -= 3
      }
    },

    resetIndex: function () {
      this.index = 0
    },

    submitNewQuestion () {
      if (this.questionForm.title != '') {
        this.addQuestion(this.questionForm)
        alert('Your question was submited')
      } else {
        alert("You can't submit an empty question")
      }
      const page_id = this.getIDbyQuestion(this.questionForm.title)
      this.questionForm = {
        title: '',
        body: '',
        author: 'Frederico',
        answers: [],
        date: '01-01-2019',
        views: 0,
        answeredStatus: -1
      }
      this.$router.replace('/question/' + page_id)
    },

    resetIndex: function () {
      this.index = 0
    }

  },

  computed: {
    ...mapState([
      'questions'
    ]),
    ...mapGetters([
      'getMyQuestions',
      'getIDbyQuestion'
    ]),

    getQuestionId: function (questionTitle) {
      return this.getIDbyQuestion(questionTitle)
    },

    orderedQuestionsByViews: function () {
      return this.questions.sort(function (item1, item2) {
        return item2.views - item1.views
      })
    },

    nonAnswerdQuestions: function () {
      return this.questions.filter(function (item) {
        return item.answers.length == 0
      })
    }

  }
}
</script>

<style>
  .question{
    padding:20px;
  }
</style>
