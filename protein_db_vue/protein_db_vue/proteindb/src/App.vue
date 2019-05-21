<template>
  <div id="app">

    <nav class="navbar navbar-expand-lg navbar-light bg-light">
      <div class="container">
        <!--<a class="navbar-brand text-style" style="padding-top: 2%" href="#">ProteinDB</a>-->
        <router-link :to="`/`" class="my-navbar-brand" style="color: #4C4C4C;padding-top: 2%; font-family: 'Baloo Bhai', cursive;">ProteinDB</router-link>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExample07" aria-controls="navbarsExample07" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" style="padding-top: 2%" id="navbarsExample07">
          <ul class="navbar-nav mr-auto">
            <div class="wrap">
              <div class="search">
                <input  @keyup.enter="search" v-model="sText" type="text" class="searchTerm" placeholder="What are you looking for?">
                <button @click="search" type="submit" class="searchButton">
                  <i class="fa fa-search"></i>
                </button>
              </div>
            </div>

          </ul>

          <ul class="navbar-nav">
            <li class="nav-item dropdown" style="color: #4C4C4C;">
              <a style="color: #4C4C4C" class="nav-link dropdown-toggle" id="dropdown07" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" href="#">
                <i style="font-size:20px;" class="fa fa-bell">
                  <span class="badge badge-info" >0</span>
                </i>
              </a>
              <div class="dropdown-menu" aria-labelledby="dropdown07">
                <a class="dropdown-item" href="#">Yet to come</a>
               
              </div>
            </li>
            <li class="nav-item">
              <a class="nav-link" style="color: #4C4C4C" href="/createproject">
                Create Project
              </a>
            </li>
            <li class="nav-item">
              <a class="nav-link" style="color: #4C4C4C" href="#">
                Sign out
              </a>
            </li>
            <li class="nav-item" >
              <a class="nav-link" style="color: #4C4C4C" href="#">
                Profile
              </a>
            </li>
           </ul>
          </div>
      </div>
    </nav>
    <nav class="navbar navbar-expand-lg navbar-light bg-light non-cellphone hide-item" style="margin-right: 85px;">
      <div class="wrap">
        <ul class="navbar-nav mr-auto">
         
          <li class="nav-item">
            <div class="form-check">
              <label>
              <b-form-checkbox
                    id="checkbox-2"
                    v-model="sFilters.proteins"
                    name="checkbox-2"
                    value=true
                    unchecked-value=false
                    >
                    Proteins
                    </b-form-checkbox>  
              </label>
            </div>
          </li>
          <li class="nav-item">
            <div class="form-check">
              <label>
                  <b-form-checkbox
                    id="checkbox-3"
                    v-model="sFilters.publications"
                    name="checkbox-3"
                    value=true
                    unchecked-value=false
                    >
                    Publications
                    </b-form-checkbox>  
              </label>
            </div>
          </li>
          <li class="nav-item">
            <div class="form-check">
              <label>
               <b-form-checkbox
                    id="checkbox-4"
                    v-model="sFilters.author"
                    name="checkbox-4"
                    value=true
                    unchecked-value=false
                    >
                    Author
                    </b-form-checkbox>  
              </label>
            </div>
          </li>
          <li class="nav-item">
            <div class="form-check">
              <label>
                <b-form-checkbox
                    id="checkbox-5"
                    v-model="sFilters.question"
                    name="checkbox-5"
                    value=true
                    unchecked-value=false
                    >
                    Question
                    </b-form-checkbox>  
              </label>
            </div>
          </li>
          <li class="nav-item">
            <div class="form-check">
              <label>
                <b-form-checkbox
                    id="checkbox-6"
                    v-model="sFilters.project"
                    name="checkbox-6"
                    value=true
                    unchecked-value=false
                    >
                    Project
                    </b-form-checkbox>  
              </label>
            </div>
          </li>
        </ul>
      </div>
     
    </nav>
    <br><br>
    <router-view/>
  </div>
</template>

<script>

import { mapGetters } from 'vuex'

export default {
  name: 'app',
  data(){
      return{
          sFilters:{
              proteins: "false",
              publications:"false",
              author:"false",
              question:"false",
              project: "false"
          },
          sText:''
          
      }
  },

   methods:{
       search(){
          //this.$router=""
          //this.$router.replace("search/"+this.sFilters.proteins+"/"+this.sFilters.publications+"/"+this.sFilters.author+"/"+this.sFilters.question+"/"+this.sFilters.project);
          this.$router.push({ path: 'search', query: { proteins: this.sFilters.proteins,
          publications: this.sFilters.publications,
          author: this.sFilters.author,
          question: this.sFilters.question,
          project: this.sFilters.project,
          searchText: this.sText
          } })
       }
   },


  components: {
  },
  
   computed:{
    ...mapGetters([
      'getLoggedInUser',
      'getIDbyUserName'
    ])
    /*
    loggedUserID(){
        let lgU=this.getLoggedInUser.name
        console.log("ola"+lgU)
        return this.getIDbyUserName(lgU)
    } */
  }
}
</script>

<style>
@import 'assets/css/arrowindexbutton.css';
@import 'assets/css/checkbox.css';
@import 'assets/css/index.css';
@import 'assets/css/indextabs.css';
@import 'assets/css/navbar.css';
@import 'assets/css/protein.css';
@import 'assets/css/search.css';
@import 'assets/css/project.css';

</style>
