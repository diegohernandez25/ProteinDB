<template>
  <div class="home">
    <!--Search box-->
    <!--<div class="container" style="padding-bottom: -100%">
        <div class="wrapHomeCellPhone">
            <div class="searchHome">
                <input type="text" class="searchTermHome" placeholder="What are you looking for?">
                <button type="submit" class="searchButtonHome">
                    <i class="fa fa-search"></i>
                </button>
            </div>

            <div class="row hide-item" style="padding-top: 2%">
                <div class="col-sm-1" style=""></div>
                <div class="col-sm-1" style="padding-left:1%; padding-right: 10%">
                    <div class="form-check">
                        <label style="width: 100px">
                            <input type="checkbox" name="check" checked> <span class="label-text">All</span>
                        </label>
                    </div>
                </div>
                <div class="col-sm-1" style="padding-right: 10%">
                    <div class="form-check">
                        <label style="width: 100px">
                            <input type="checkbox" name="check" checked> <span class="label-text">Proteins</span>
                        </label>
                    </div>
                </div>
                <div class="col-sm-1" style="padding-right: 12%">
                    <div class="form-check">
                        <label style="width: 120px">
                            <input type="checkbox" name="check" checked> <span class="label-text">Publications</span>
                        </label>
                    </div>
                </div>
                <div class="col-sm-1" style="padding-right: 10%">
                    <div class="form-check">
                        <label style="width: 100px">
                            <input type="checkbox" name="check" checked> <span class="label-text">Author</span>
                        </label>
                    </div>
                </div>
                <div class="col-sm-1" style="padding-right: 10%">
                    <div class="form-check">
                        <label style="width: 100px">
                            <input type="checkbox" name="check" checked> <span class="label-text">Question</span>
                        </label>
                    </div>
                </div>
                <div class="col-sm-1" style="padding-right: 10%">
                    <div class="form-check">
                        <label style="width: 100px">
                            <input type="checkbox" name="check" checked> <span class="label-text">Project</span>
                        </label>
                    </div>
                </div>
            </div>

        </div>
    </div>-->
    <!--Question section-->
    <div class="container" style="padding-top: 10px">
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
            </div>
            <div class="row" style="padding-left: 5%; padding-top: 3%">
                <div class="col-sm-9">
                    <input type="text" class="tag-text" placeholder="➕ add tag" style="width: 12%">
                </div>
                <div class="col-sm-3">
                    <button @click="submitNewQuestion()" type="submit" class="submit-question">
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
        <div class="container" style="padding-top: 5%; padding-bottom: 2%">
                <div class="row">
                    <div class="col-sm-9">
                    </div>
                    <div class="col-sm-1">
                        <div class="center-con" style="transform: rotate(180deg)" >
                            <div v-on:click="prev()" class="round">
                                <div id="cta-back" >
                                    <span class="arrow primera next "></span>
                                    <span class="arrow segunda next "></span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-1">
                        <div class="center-con" >
                            <div v-on:click="next()" class="round">
                                <div id="cta">
                                    <span class="arrow primera next "></span>
                                    <span class="arrow segunda next "></span>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-1">

                    </div>
                </div>
            </div>
            <br>
            <br>
     </b-tabs>
    </div>
    <div>
    <b-table striped hover :items="nonAnswerdQuestions" :fields="fields"></b-table>
  </div>
  </div>
</template>

<script>
// @ is an alias to /src
import Question from '@/components/questionPrev.vue'

import { mapState, mapActions } from 'vuex'

export default {
  name: 'home',
  components: {
    Question
  },

   data() {
      return {
        fields: ['title'],
        index: 0,
        tabIndex:0,
        questionForm: {
                title: '',
                body: '',
                author: 'Frederico',
                answers: [],
                date: '01-01-2019',
                views:0,
                answeredStatus:-1
            },
      }
    },

    methods:{
        ...mapActions([
            'addQuestion'
        ]),

        next: function(){
            if(this.tabIndex==0){
                if(this.orderedQuestionsByViews.length>this.index+3){
                    this.index+=3;
                }
            }
            else{
                if(this.nonAnswerdQuestions.length>this.index+3){
                    this.index+=3;
                }
            }

        },

        prev: function(){
            if(this.index>0){
                this.index-=3;
            }
        },

        resetIndex: function(){
            this.index=0;
        },

        submitNewQuestion(){

            if(this.questionForm.title!=''){
                this.addQuestion(this.questionForm);
                alert("Your question was submited")
            }
            else{
                alert("You can't submit an empty question")
            }
            this.questionForm= {
                title: '',
                body: '',
                author: 'Frederico',
                answers: [],
                date: '01-01-2019',
                views:0,
                answeredStatus:-1
            }

        },



    resetIndex: function () {
      this.index = 0
    },

    submitNewQuestion () {
      this.addQuestion(question)
    }

  },

  computed: {
    ...mapState([
      'questions'
    ]),

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
