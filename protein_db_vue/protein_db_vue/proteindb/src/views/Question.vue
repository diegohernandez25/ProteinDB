<template>
  <div class="home">
      <div style="padding-top: 3%">
    <!--Question section-->
    <div class="container home-question-ans">
        <div class="row question-tabs">
            <div class="col-sm-12">
                {{currentQuestion.title}}
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <p>
                      {{currentQuestion.body}}
                </p>

            </div>
            <br>

        </div>
        <div class="row">
            <div class="col-sm-6">
                <span style="font-size: 16px">Question Submited by:</span>
            </div>
            <div class="col-sm-2">
                <span style="font-size: 16px">Submited in:</span>
            </div>
            <div class="col-sm-3">
                <span style="font-size: 16px">Marked as:</span>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-1 hide-item">
                <img src="../assets/images/avatar.png" alt="Avatar" class="avatar">
            </div>
            <div class="col-sm-5">
                <a class="avatar-name-ans" href="#">{{currentQuestion.author}}</a>
                <br>
                <span class="avatar-workplace">University of Aveiro - Biology Master Degree</span>
            </div>
            <div class="col-sm-1 show-item" style="display: none"></div>
            <div class="col-sm-2">
                <span class="ans-date" style="font-size: 15px">{{currentQuestion.date}}</span>
            </div>
            <div class="col-sm-3">
                <span v-if="currentQuestion.answeredStatus>=0" span style="font-size: 20px; color: grey;">Answered ✔️</span>
                <span v-else-if="currentQuestion.answeredStatus<0" span style="font-size: 15px; color: grey;">Not Answered</span>
            </div>
        </div>
        <br>
    </div>
</div>

<!--Your Answer Label-->
<div class="container" style="padding-top: 3%">
    <div class="row">
        <div class="col-sm-11">
            <span class="container-label" style="font-family: 'Baloo Bhai', cursive; margin-top: 100px">Your Answer</span>
            <div class="btn-group" style="font-size: 30px">
                <button type="button" class="btn  dropdown-toggle" data-toggle="dropdown"
                        aria-haspopup="true" aria-expanded="false" style="margin-left: 25px; background-color: #00B4CC">
                    <img src="../assets/images/settings.png" alt="Settings" style="height: 30px; width: 30px;">
                </button>
                <span></span>
                <div class="dropdown-menu">
                    <a class="dropdown-item" href="#">Edit Answer</a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="#">Delete Answer</a>
                </div>
            </div>
        </div>
        <div class="col-sm-1">
        </div>
    </div>
</div>

<!--Your answer-->

<div v-for="(answer,index) in currentQuestion.answers" v-bind:key="index">
     <answerRes2 v-if="answer.author=='Frederico'"
            :answer2=answer
        />

</div>

<!--Write Answer section-->
<div style="padding-top: 3%">
    <div class="container home-question-ans" style="padding: 10px">
        <div class="row">
            <div class="col-sm-1 hide-item">
                <img src="../assets/images/avatar.png" alt="Avatar" class="avatar">
            </div>
            <div class="col-sm-11">
                <a class="avatar-name" href="#">Frederico Gratinad</a>
                <br>
                <span class="avatar-workplace">University of Aveiro - Biology Master Degree</span>
            </div>

        </div>
        <div class="form-group">
            <label for="exampleFormControlTextarea3"></label>
            <textarea class="form-control write-answer" id="exampleFormControlTextarea3" placeholder="Write your Answer" rows="7"
            style="border: none"></textarea>
        </div>
        <div class="row" style="padding-left: 5%; padding-top: 3%">
            <div class="col-sm-9">
                <input type="text" class="tag-text" placeholder="➕ add tag" style="width: 12%">
            </div>
            <div class="col-sm-3">
                <button type="submit" class="submit-question">
                    Submit
                </button>
            </div>
        </div>
    </div>
</div>

<!--Others Answer Label-->
<div class="container" style="padding-top: 3%">
    <div class="row">
        <div class="col-sm-12">
            <span class="container-label" style="font-family: 'Baloo Bhai', cursive; margin-top: 100px">Answers</span>
        </div>
    </div>
</div>

<div class="container-fluid all-answers normal-container-fluid" >
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <span class="chosen-answer-label" style="font-family: 'Baloo Bhai', cursive;">Chosen Answer ⭐</span>
            </div>
        </div>
    </div>

        <answerRes2
            :answer2=correctAnswer
        />

        <br>
        <br>

    <br>
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <span class="other-answer-label" style="font-family: 'Baloo Bhai', cursive;">Other Answers</span>
                <div class="btn-group" style="font-size: 30px">
                    <button type="button" class="btn  dropdown-toggle" data-toggle="dropdown"
                            aria-haspopup="true" aria-expanded="false" style="margin-left: 25px; background-color: #00B4CC">
                        <span style="font-size: 20px; color: white">Filter By</span>
                    </button>
                    <span></span>
                    <div class="dropdown-menu">
                        <a class="dropdown-item" href="#">Most Upvoted</a>
                        <a class="dropdown-item" href="#">Least Upvoted</a>
                        <div class="dropdown-divider"></div>
                        <a class="dropdown-item" href="#">Most Recent</a>
                        <a class="dropdown-item" href="#">Oldest</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br>
    <div v-for="(answer,index) in currentQuestion.answers" v-bind:key="index" >
            <answerRes2 v-if="index!==currentQuestion.answeredStatus"
            :answer2=answer
            />
        <br>
        <br>
    </div>
    <br>

    <div class="container" style="padding-top: 5%; padding-bottom: 2%">
        <div class="row">
            <div class="col-sm-9">
            </div>
            <div class="col-sm-1">
                <div class="center-con" style="transform: rotate(180deg)" >
                    <div class="round">
                        <div id="cta-back2" >
                            <span class="arrow primera next "></span>
                            <span class="arrow segunda next "></span>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-1">
                <div class="center-con" >
                    <div class="round">
                        <div id="cta2">
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
</div>
  </div>
</template>

<script>
// @ is an alias to /src

import { mapState } from 'vuex'
import answerRes2 from '@/components/answerRes2.vue'

export default {
  name: 'profile',
  components: {
    answerRes2
  },

  data () {
    return {
      currentQuestion: {},
      correctAnswer: {}
    }
  },

  methods: {

  },

  computed: {
    ...mapState([
      'users',
      'questions'
    ])

  },

  mounted () {
    let curQ = this['questions'][this.$route.params.id]
    this.currentQuestion = curQ

    let corrA = curQ['answeredStatus']
    this.correctAnswer = curQ['answers'][corrA]
  }

}
</script>

<style>
 @import '../assets/css/question.css';
</style>
