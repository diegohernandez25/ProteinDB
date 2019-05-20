<template>
  <div id="app">

    <nav class="navbar navbar-expand-lg navbar-light bg-light">
      <div class="container">
        <!--<a class="navbar-brand text-style" style="padding-top: 2%" href="#">ProteinDB</a>-->
        <a class="my-navbar-brand" style="color: #4C4C4C;padding-top: 2%; font-family: 'Baloo Bhai', cursive;">ProteinDB</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExample07" aria-controls="navbarsExample07" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" style="padding-top: 2%" id="navbarsExample07">
          <ul class="navbar-nav mr-auto">
            <div class="wrap">
              <div class="search">
                <input type="text" class="searchTerm" placeholder="What are you looking for?">
                <button type="submit" class="searchButton">
                  <i class="fa fa-search"></i>
                </button>
              </div>
            </div>

          </ul>

          <ul class="navbar-nav">
            <li class="nav-item dropdown" style="color: #4C4C4C;">
              <a style="color: #4C4C4C" class="nav-link dropdown-toggle" id="dropdown07" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" href="#">
                <i style="font-size:20px;" class="fa fa-bell">
                  <span class="badge badge-info" >11</span>
                </i>
              </a>
              <div class="dropdown-menu" aria-labelledby="dropdown07">
                <a class="dropdown-item" href="#">Action</a>
                <a class="dropdown-item" href="#">Another action</a>
                <a class="dropdown-item" href="#">Something else here</a>
              </div>
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
    <nav class="navbar navbar-expand-lg navbar-light bg-light non-cellphone hide-item">
      <div class="wrap">
        <ul class="navbar-nav mr-auto">
          <li class="nav-item">
            <div class="form-check">
              <label>
                <input type="checkbox" name="check" checked> <span class="label-text">All</span>
              </label>
            </div>
          </li>
          <li class="nav-item">
            <div class="form-check">
              <label>
                <input type="checkbox" name="check" checked> <span class="label-text">Proteins</span>
              </label>
            </div>
          </li>
          <li class="nav-item">
            <div class="form-check">
              <label>
                <input type="checkbox" name="check" checked> <span class="label-text">Publications</span>
              </label>
            </div>
          </li>
          <li class="nav-item">
            <div class="form-check">
              <label>
                <input type="checkbox" name="check" checked> <span class="label-text">Author</span>
              </label>
            </div>
          </li>
          <li class="nav-item">
            <div class="form-check">
              <label>
                <input type="checkbox" name="check" checked> <span class="label-text">Question</span>
              </label>
            </div>
          </li>
          <li class="nav-item">
            <div class="form-check">
              <label>
                <input type="checkbox" name="check" checked> <span class="label-text">Project</span>
              </label>
            </div>
          </li>
        </ul>
      </div>
    </nav>

    <router-view/>
  </div>
</template>

<script>

import {mapGetters} from 'vuex'

export default {
  name: 'app',
  components: {
  },
   computed:{
    ...mapGetters([
        'getLoggedInUser',
        'getIDbyUserName'
    ]),
    /*
    loggedUserID(){
        let lgU=this.getLoggedInUser.name
        console.log("ola"+lgU)
        return this.getIDbyUserName(lgU)
    }*/
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

</style>
