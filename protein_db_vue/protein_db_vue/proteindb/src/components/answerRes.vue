
<template>
    <div class="result-item-answer">
        <div>

            <h2 style="flex:20"><router-link class="other-answer-label" style="color:grey" :to="`/question/${getID}`">{{answer.question}}</router-link></h2>

            <div>
                <button type="button" class="btn add-button"><i class="fas fa-pencil-alt"></i></button>
            </div>
        </div>

        <div class="profile-answers-item">
            <img src="../assets/images/profile.jpg" alt="">
            <div>
                    <b>User: </b>{{answer.author}} <br>
                    <b>Date: </b>{{answer.date}}
            </div>
        </div>
        <div>
            <p><b>Answer:</b> {{answer.text}}</p>
        </div>
        <div class="result-item-answer-bottom-row">
            <a href="">more</a>
            <div>
                <div>  <button style=" font-size: 130%"
                        type="button"
                        id="testBtn"
                        class="btn btn-success glyphicon glyphicon-thumbs-up"
                        data-loading-text=" ... ">👍 {{answer.upvotes}}</button> </div>
                <div>  <button style=" font-size: 130%"
                        type="button"
                        id="testBtn"
                        class="btn btn-danger glyphicon glyphicon-thumbs-up"
                        data-loading-text=" ... ">👎 {{answer.downvotes}}</button> </div>
            </div>
        </div>
    </div>
</template>

<script>

import { mapState, mapGetters } from 'vuex'

export default {
  name: 'answerPrev',
  props: {
    answer: Object
  },

  computed: {
    ...mapState([
      'users'
    ]),

    ...mapGetters([
      'getIDbyQuestion'
    ]),

    getID () {
      let x = this.getIDbyQuestion(this.answer.question)
      return x
    }

  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style>

</style>
