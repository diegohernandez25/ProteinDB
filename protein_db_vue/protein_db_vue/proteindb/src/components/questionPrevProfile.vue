<template>
  <div>
    <div class="row question-tabs">
      <div class="col-sm-11">
        <router-link class="other-answer-label" :to="`/question/${getID}`">{{question.title}}</router-link>
      </div>
      <div class="col-sm-1">
        <button type="button" class="btn add-button"><i class="fas fa-pencil-alt"></i></button>
      </div>
    </div>
    <div class="row">
      <div class="col-sm-12">
        <p><span style="color: white">qdnqjdwjkdnqwkdnwqdnjqwkdnqwjkdnjkqwdkwqndwqjkndjkwqndjkwqndjkqwnjkdnwqjkdnqwjkndjqwndjkwqndkjqwndjkqwndjkwnjdknwqjkdnqwjkndjqwndjwqjkdnqwjknkwdjkqwndjkwnjdknqwjk</span>
        </p>
        <p sty>
          {{question.body}}
        </p>
         <router-link  :to="`/question/${getID}`">more...</router-link>
      </div>
      <br>

    </div>
    <div class="row">
      <div class="col-sm-6">
        <span style="font-size: 16px">Answer Submited by:</span>
      </div>
      <div class="col-sm-2">
        <span style="font-size: 16px">Submited in:</span>
      </div>
    </div>
    <div class="row">
      <div class="col-sm-1 hide-item">
        <img src="../assets/images/avatar.png" alt="Avatar" class="avatar">
      </div>
      <div class="col-sm-5">

        <router-link :to="`/profile/${userInfo.id}`" class="avatar-name-ans">{{question.author}} </router-link>
        <br>
        <span class="avatar-workplace">{{userInfo.university}} - {{userInfo.degree}}</span>
      </div>
      <div class="col-sm-3">
        <span class="ans-date" style="font-size: 15px">{{question.date}}</span>
      </div>
      <div class="col-sm-2">
        <p>{{question.answers.length}} answers.</p>
      </div>
    </div>
    <br>
  </div>
</template>

<script>

import { mapState, mapGetters } from 'vuex'

export default {
  name: 'questionPrev',
  props: {
    question: Object
  },

  computed: {
    ...mapState([
      'users'
    ]),

    ...mapGetters([
      'getIDbyQuestion'
    ]),

    getID () {
      let x = this.getIDbyQuestion(this.question.title)
      return x
    },

    userInfo: function () {
      let questAuth = this.question.author
      let user = this.users.find(function (user) {
        return user.name == questAuth
      })
      return user
    }
  }

}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style>

</style>
