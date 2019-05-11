import Vue from 'vue'
import Router from 'vue-router'
import HelloWorld from '@/components/HelloWorld'
import index from '@/components/index'
import Tutorial from '@/components/Tutorial'
Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'HelloWorld',
      component: HelloWorld
    },
    {
      path: '/index',
      name: 'index',
      component: index
    },
    {
      path: '/tutorial',
      name: 'Tutorial',
      component: Tutorial
    }
  ]
})

Vue.component('todo-item', {
  props: ['todo'],
  template: '<li>{{ todo.text }}</li>'
})

// eslint-disable-next-line no-new
new Vue({
  el: '#app-7',
  data: {
    groceryList: [
      {id: 0, text: 'Vegetables'},
      {id: 1, text: 'Cheese'},
      {id: 2, text: 'Whatever.'}
    ]
  }
})

Vue.component('user-name', {
  props: ['name'],
  // language=HTML
  template: '<p>Hi {{name}}</p>'
})
