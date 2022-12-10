import Vue from 'vue'
import VueRouter from 'vue-router'
import WebHome from '../components/WebHome.vue'
import AboutView from '../views/AboutView.vue'
import WebLogin from '../components/WebLogin.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/home',
    component: WebHome
  },
  {
    path: '/about',
    views: AboutView
  },
  {
    path: '/login',
    component: WebLogin
  }
]

const router = new VueRouter({
  routes
})

export default router
