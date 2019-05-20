import Vue from 'vue'
import Router from 'vue-router'
import Home from './views/Home.vue'
import Profile from './views/Profile.vue'
import Question from './views/Question.vue'
import Protein from './views/Protein.vue'
import Search from './views/Search.vue'

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home
    },

    {
      path: '/profile/:id',
      name: 'profile',
      component: Profile
    },

    {
      path: '/question/:id',
      name: 'question',
      component: Question
    },

    {
      path: '/protein/:id',
      name: 'protein',
      component: Protein
    },

    {
      path: '/search/:id',
      name: 'search',
      component: Search
    }

  ],
  scrollBehavior (to, from, savedPosition) {
    return { x: 0, y: 0 }
  }
})
