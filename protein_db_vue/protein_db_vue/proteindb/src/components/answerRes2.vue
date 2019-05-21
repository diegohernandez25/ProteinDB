<template>
    <div class="container home-question-ans" style="padding: 10px">
        <div class="row">
            <div class="col-sm-12">
                <p>
                    {{answer2.text}}
                </p>

            </div>
            <br>

        </div>
        <div class="row">
            <div class="col-sm-5">
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
            <div class="col-sm-4">
                <router-link :to="`/profile/${getID}`" class="avatar-name-ans" href="#">{{answer2.author}}</router-link>
                <br>
                <span class="avatar-workplace">{{userInfo.university}} - {{userInfo.degree}}</span>
            </div>

            <div class="col-sm-3">
                <span class="ans-date" style="font-size: 15px">{{answer2.date}}</span>
            </div>
            <div class="col-sm-3">
                <button style=" font-size: 130%"
                        type="button"
                        id="testBtn"
                        class="btn btn-danger glyphicon glyphicon-thumbs-up"
                        data-loading-text=" ... ">👎 {{answer2.downvotes}}</button>
                <button style="font-size: 130%; margin-left: 10%"
                        type="button" id="testBtnDown" class="btn btn-success glyphicon glyphicon-thumbs-down" data-loading-text=" ... ">👍 {{answer2.upvotes}}</button>

            </div>
        </div>
    </div>
</template>

<script>

import { mapState, mapGetters } from 'vuex'

export default {
  name: 'answerPrev2',
  props: {
    answer2: Object
  },

  computed: {
    ...mapState([
      'users'
    ]),

    ...mapGetters([
      'getIDbyUserName'
    ]),

    getID () {
      let uN = this.answer2.author
      return this.getIDbyUserName(uN)
    },

    userInfo: function () {
      let c = this.answer2.author
      console.log(c)
      let user = this.users.find(function (user) {
        return user.name == c
      })
      return user
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style>

</style>
