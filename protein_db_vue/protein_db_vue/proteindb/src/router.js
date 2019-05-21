import Vue from 'vue'
import Router from 'vue-router'
import Home from './views/Home.vue'
import Profile from './views/Profile.vue'
import Question from './views/Question.vue'
import Protein from './views/Protein.vue'
import Search from './views/Search.vue'
import CreateProject from './views/CreateProject.vue'
import Project from './views/Project.vue'

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
      path: '/search',
      name: 'search',
      component: Search
    },

    {
      path: '/createproject/',
      name: 'createproject',
      component: CreateProject
    },

    {
      path: '/project/:id',
      name: 'project',
      component: Project
    }

  ],
  scrollBehavior (to, from, savedPosition) {
    return { x: 0, y: 0 }
  }
})
