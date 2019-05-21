<template>
  <div id="project" class="container-fluid" style="width: 80%">
    <div class=screen>
      <div class=main-content>
        <div class=project-info>
          <div class="project-info-header">
            <h1 style="color: gray">{{project.name}}</h1>
            <button type="button" class="btn add-button side-edit-btn"><i class="fas fa-pencil-alt"></i></button>
          </div>
          <div class="project-info-description">
            <b>Description:</b>
            <br>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
          </div>
          <div class="project-info-associated">
            <b>Proteins Associated:</b>
            <br>
            <div class=listAssProts>
              <button type="button" class="btn add-button prot-btn ">Protein 1 </button>
              <button type="button" class="btn add-button prot-btn ">Protein 1 </button>
            </div>
            <div class=project-info-persons>
              <div>
                <h2 style="color: gray"> Manager: </h2><br>
                <div class=list-users >
                  <div class=user>
                    <img src="../assets/images/profile.jpg" alt="">
                    <p>{{project.manager}}</p>
                  </div>
                </div>
              </div>
              <div>
                <h2 style="color: gray"> Members: </h2><br>
                <div class=list-users>
                  <div v-for="(member,index) in project.members" v-bind:key="index" class=user>
                    <img src="../assets/images/profile.jpg" alt="">
                    <p>{{member}}</p>
                  </div>
                </div>
              </div>
            </div>
          </div>

          <div class="container articles-section">

            <div class="project-info-header">
              <h1 style="color: gray">Published Articles</h1>
              <button type="button" class="btn add-button side-edit-btn"><i class="fas fa-pencil-alt"></i></button>
            </div>
            <button type="button" class="btn add-button add-ac" style="margin:10px 0" >Add article</button>
            <div class=filter-row>
              <select>
                <option value="volvo">Recent</option>
                <option value="saab">Older</option>
              </select>
              <input type="text" name="Search" placeholder="Search"><br>
            </div>
            <div class="item">
              <div class="item-head">
                <div>
                  <h2 style="color: gray">Name of article </h2>
                  <p>Institute name</p>
                </div>

                <div> N <i class="fas fa-star" style="color: rgba(255, 217, 0, 0.993);"></i> </div>
                <i class="fas fa-check"></i>
              </div>

              <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
              <a href="">link</a>
              <div>
                <p>By:</p>
                <div class=list-users>
                  <div class=user>
                    <img src="../assets/images/profile.jpg" alt="">
                    <p>User 1</p>
                  </div>
                  <div class=user>
                    <img src="../assets/images/profile.jpg" alt="">
                    <p>User 2</p>
                  </div>
                  <div class=user>
                    <img src="../assets/images/profile.jpg" alt="">
                    <p>User 3</p>
                  </div>
                  <div class="date">
                    <p>Date</p>
                  </div>
                </div>

              </div>
            </div>
            <div class="prev-next">
              <button type="button" class="btn add-button side-edit-btn"><i class="fas fa-arrow-right"></i></button>
              <button type="button" class="btn add-button side-edit-btn"><i class="fas fa-arrow-left"></i></button>
            </div>

            <br>
          </div>
          <br>
          
          <div class="container articles-section">

            <div class="project-info-header">
              <h1 style="color: gray">Relevant Articles/Bibliography</h1>
              <button type="button" class="btn add-button side-edit-btn"><i class="fas fa-pencil-alt"></i></button>
            </div>
            <button type="button" class="btn add-button add-ac" style="margin:10px 0" >Add article</button>
            <div class=filter-row>
              <select>
                <option value="volvo">Recent</option>
                <option value="saab">Older</option>
              </select>
              <input type="text" name="Search" placeholder="Search"><br>
            </div>
            <div class="item">
              <div class="item-head">
                <div>
                  <h2 style="color: gray">Name of article </h2>
                  <p>Institute name</p>
                </div>

                <div> N <i class="fas fa-star" style="color: rgba(255, 217, 0, 0.993);"></i> </div>
                <i class="fas fa-check"></i>
              </div>

              <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
              <a href="">link</a>
              <div>
                <p>By:</p>
                <div class=list-users>
                  <div class=user>
                    <img src="../assets/images/profile.jpg" alt="">
                    <p>User 1</p>
                  </div>
                  <div class=user>
                    <img src="../assets/images/profile.jpg" alt="">
                    <p>User 2</p>
                  </div>
                  <div class=user>
                    <img src="../assets/images/profile.jpg" alt="">
                    <p>User 3</p>
                  </div>
                  <div class="date">
                    <p>Date</p>
                  </div>
                </div>

              </div>
            </div>
            <div class="prev-next">
              <button type="button" class="btn add-button side-edit-btn"><i class="fas fa-arrow-right"></i></button>
              <button type="button" class="btn add-button side-edit-btn"><i class="fas fa-arrow-left"></i></button>
            </div>

            <br>
          </div>

          

          <br>
          <div class="container articles-section">
            <div class="project-info-header">
              <h1 style="color: gray">Contributions</h1>
              <button type="button" class="btn add-button side-edit-btn"><i class="fas fa-pencil-alt"></i></button>
            </div>
            <button type="button" class="btn add-button add-ac ">Add Contribution</button>
            <div class=filter-row>
              <select>
                <option value="volvo">Recent</option>
                <option value="saab">Older</option>
              </select>
              <input type="text" name="Search" placeholder="Search"><br>
            </div>
            <div class="item">
              <div class="item-head">
                <div>
                  <h2 style="color: gray">Contribution 1  </h2>
                  <p>Commit msg</p>
                </div>

              </div>

              <a href="">more</a>
              <div>
                <p>By:</p>
                <div class=list-users>
                  <div class=user>
                    <img src="../assets/images/profile.jpg" alt="">
                    <p>User 1</p>
                  </div>
                  <div class=user>
                    <img src="../assets/images/profile.jpg" alt="">
                    <p>User 2</p>
                  </div>
                  <div class=user>
                    <img src="../assets/images/profile.jpg" alt="">
                    <p>User 3</p>
                  </div>
                  <div class="date">
                    <p>Date</p>
                  </div>
                </div>
              </div>
            </div>
            <div class="item">
              <div class="item-head">
                <div>
                  <h2 style="color: gray">Contribution 2  </h2>
                  <p>Commit msg</p>
                </div>
              </div>
              <a href="">more</a>
              <div>
                <p>By:</p>
                <div class=list-users>
                  <div class=user>
                    <img src="../assets/images/profile.jpg" alt="">
                    <p>User 1</p>
                  </div>
                  <div class=user>
                    <img src="../assets/images/profile.jpg" alt="">
                    <p>User 2</p>
                  </div>
                  <div class=user>
                    <img src="../assets/images/profile.jpg" alt="">
                    <p>User 3</p>
                  </div>
                  <div class="date">
                    <p>Date</p>
                  </div>
                </div>
              </div>
            </div>
            <div class="prev-next">
              <button type="button" class="btn add-button side-edit-btn"><i class="fas fa-arrow-right"></i></button>
              <button type="button" class="btn add-button side-edit-btn"><i class="fas fa-arrow-left"></i></button>
            </div>
          </div>
        </div>
      </div>
    </div>
   </div>
</template>

<script>
import { mapGetters } from 'vuex'

export default {
  name: 'Project',
  data(){
    return{

    }
  },

  methods: {
   
  },

  computed:{
     ...mapGetters([
      'getProjectByID'
    ]),

    project(){
      console.log(this.$route.params.id);
      return this.getProjectByID(this.$route.params.id);
    }
  }

}



</script>

<style scoped>

</style>
