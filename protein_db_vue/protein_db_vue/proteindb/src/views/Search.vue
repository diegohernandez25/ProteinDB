<template>
  <div id="search">

    <!--Search box-->
    <div class="container show-item" style="padding-bottom: -100%; display: none">
      <div class="wrapHomeCellPhone">
        <div class="searchHome">
          <input type="text" class="searchTermHome" placeholder="What are you looking for?">
          <button type="submit" class="searchButtonHome">
            <i class="fa fa-search"></i>
          </button>
        </div>
        <div class="row hide-item" style="padding-top: 2%">
          <div class="col-sm-1" style=""></div>
          <div class="col-sm-1" style="padding-left:1%; padding-right: 10%">
            <div class="form-check">
              <label style="width: 100px">
                <input type="checkbox" name="check" checked> <span class="label-text">All</span>
              </label>
            </div>
          </div>
          <div class="col-sm-1" style="padding-right: 10%">
            <div class="form-check">
              <label style="width: 100px">
                <input type="checkbox" name="check" checked> <span class="label-text">Proteins</span>
              </label>
            </div>
          </div>
          <div class="col-sm-1" style="padding-right: 12%">
            <div class="form-check">
              <label style="width: 120px">
                <input type="checkbox" name="check" checked> <span class="label-text">Publications</span>
              </label>
            </div>
          </div>
          <div class="col-sm-1" style="padding-right: 10%">
            <div class="form-check">
              <label style="width: 100px">
                <input type="checkbox" name="check" checked> <span class="label-text">Author</span>
              </label>
            </div>
          </div>
          <div class="col-sm-1" style="padding-right: 10%">
            <div class="form-check">
              <label style="width: 100px">
                <input type="checkbox" name="check" checked> <span class="label-text">Question</span>
              </label>
            </div>
          </div>
          <div class="col-sm-1" style="padding-right: 10%">
            <div class="form-check">
              <label style="width: 100px">
                <input type="checkbox" name="check" checked> <span class="label-text">Project</span>
              </label>
            </div>
          </div>
        </div>
      </div>
    </div>

    <!--Main body-->
    <div class="container-fluid" style="width: 60%;">
      <!--Filter bar-->
      <!--Not visible in smartphone-->
      <div class="row">
        <div class="col-sm-2 hide-item ">
          <div class="filter-section">
            <div>
              <a class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Filter</a>
            </div>
            By category:
            <div>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false">➕ All</button>
            </div>
            <div>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false">➕ Proteins</button>
            </div>
            <div>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false">➕ <span style="font-size: 14px">Publications </span></button>

            </div>
            <div>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false">➕ Author</button>

            </div>
            <div>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false">➕ Question</button>

            </div>
            <div>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false">➕ Project</button>
            </div>
            By date:
            <div>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false">➕ Recent</button>
            </div>
            <div>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false">➕ Oldest</button>
            </div>
            By Popularity:
            <div>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false">➕ Popular</button>
            </div>
          </div>
        </div>
        <!--Result section-->
        <div class="col-sm-10 increment-col">
          <div>
            <a class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                font-family: 'Baloo Bhai', cursive;">Chosen Filters</a>
          </div>
          <div v-for="(param,index) in listOfParams" v-bind:key="index">
           
            
            <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false">❌</button>
            <span style="font-size: 20px">{{param}}</span>

          </div>
          <!--
          <div class="search-container" style="background-color: #eee; padding: 15px; margin-top: 10px">
            <div style="margin-top: 15px">
                    <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Results for: <span style="color: gray">"Frederico Gratinad"</span>
                        in <span style="color: gray">Publication</span></span>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false"
                      style="font-size: 20px;margin-left: 10px">Hide ⬆️️</button>
            </div>

            <div class="container filter-container" >

                    <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Search By:</span>

              <div class="row">
                <div class="col-sm-3">
                  <label>Publication Initial Date:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="dd-mm-yyyy">
                </div>
                <div class="col-sm-3">
                  <label>Publication Final Date:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="dd-mm-yyyy">
                </div>
              </div>

              <div class="row">
                <div class="col-sm-3">
                  <label>Submition Initial Date:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="dd-mm-yyyy">
                </div>
                <div class="col-sm-3">
                  <label>Submition Final Date:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="dd-mm-yyyy">
                </div>
              </div>

              <div class="row">
                <div class="col-sm-3">
                  <label>Authors:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="ex: Frederico, Gratinad">
                </div>
                <div class="col-sm-3">
                  <label>Institute/University:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="ex: University of Aveiro, FEUP">
                </div>
              </div>
              <div class="row">
                <div class="col-sm-3">
                  <label>Proteins:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="ex: Frederico, Fred">
                </div>
                <div class="col-sm-3"></div>
                <div class="col-sm-1">
                  <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false"
                          style="font-size: 20px;">Filter️️</button>
                </div>
              </div>
            </div>

            <br>

            <div class="container home-question-ans" style="margin-top: 15px">
              <div class="row question-tabs">
                <div class="col-sm-12">
                  Métodos para salvar pinheiros
                </div>
              </div>
              <div class="row">
                <div class="col-sm-12">
                  <p>As armas e os barões assinalados,
                    Que da ocidental praia Lusitana,
                    Por mares nunca de antes navegados,
                    Passaram ainda além da Taprobana,
                    Em perigos e guerras esforçados,
                    Mais do que prometia a força humana,
                    E entre gente remota edificaram
                    Novo Reino, que tanto sublimaram;
                    As armas e os barões assinalados,
                    Que da ocidental praia Lusitana,
                    Por mares nunca de antes navegados,
                    Passaram ainda além da Taprobana,
                    Em perigos e guerras esforçados,
                    Mais do que prometia a força humana,
                    E entre gente remota edificaram
                    Novo Reino, que tanto sublimaram;
                  </p>
                </div>
                <br>
              </div>
              <div class="row">
                <div class="col-sm-12">
                  <span style="font-size: 16px">Proteins associated with publication:</span>
                  <br><br>
                  <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Protein </button>
                  <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Protein 1</button>
                  <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Protein 2</button>
                </div>
              </div>
              <br>
              <div class="row">
                <div class="col-sm-5">
                  <span style="font-size: 16px">Authors:</span>
                  <br>
                  <span class="avatar-workplace">Frederico Gratinad, Frederico Gratinad, Frederico Gratinad, Frederico Gratinad
                              </span>
                </div>
                <div class="col-sm-5">
                  <span style="font-size: 16px">Universities and Institutes associated to research:</span>
                  <br>
                  <span class="avatar-workplace">Universidade de Aveiro
                              </span>
                </div>
                <div class="col-sm-2">
                  <span style="font-size: 16px">Publication Date:</span>
                  <br>
                  <span class="avatar-workplace">25-03-1996
                              </span>
                </div>
              </div>

              <div class="row">
                <div class="col-sm-5">
                  <span style="font-size: 16px">Publication Submited by:</span>
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
                  <a class="avatar-name-ans" href="#">Frederico Gratinad</a>
                  <br>
                  <span class="avatar-workplace">University of Aveiro - Biology Master Degree</span>
                </div>
                <div class="col-sm-3">
                  <span class="avatar-workplace">25-03-1996</span>
                </div>
                <div class="col-sm-4">
                  <div class="result-item-answer-bottom-row">
                    <div>
                      <div>  <button type="button" class="btn btn-primary grey-button protein-buttons"><i class="fas fa-thumbs-up"></i></button> 4 </div>
                      <div>  <button type="button" class="btn btn-primary grey-button protein-buttons"><i class="fas fa-thumbs-down"></i></button> 4</div>
                    </div>
                  </div>
                </div>
              </div>
              <br>
            </div>
            <br>
            <br>
            <div class="container" style="padding-top: 1%; padding-bottom: 2%">
              <div class="row">
                <div class="col-sm-9">
                </div>
                <div class="col-sm-1">
                  <div class="center-con" style="transform: rotate(180deg)" >
                    <div class="round">
                      <div id="cta-back2" >
                        <span class="arrow primera next "></span>
                        <span class="arrow segunda next "></span>
                      </div>
                    </div>
                  </div>
                </div>
                <span style="font-family: 'Baloo Bhai', cursive;font-size: 20px; color: #4C4C4C">3</span>
                <div class="col-sm-1">
                  <div class="center-con" >
                    <div class="round">
                      <div id="cta2">
                        <span class="arrow primera next "></span>
                        <span class="arrow segunda next "></span>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="col-sm-1">

                </div>
              </div>
            </div>
          </div>
  -->
          <!--
          <div class="search-container" style="background-color: #eee; padding: 15px; margin-top: 10px">
            <div style="margin-top: 15px">
                    <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Results for: <span style="color: gray">"Frederico Gratinad"</span>
                        in <span style="color: gray">Project</span></span>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false"
                      style="font-size: 20px;margin-left: 10px">Hide ⬆️️</button>
            </div>
            <br>
            <div class="container filter-container" >

                    <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Search By:</span>

              <div class="row">
                <div class="col-sm-3">
                  <label>Publication Initial Date:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="dd-mm-yyyy">
                </div>
                <div class="col-sm-3">
                  <label>Publication Final Date:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="dd-mm-yyyy">
                </div>
              </div>

              <div class="row">
                <div class="col-sm-3">
                  <label>Submition Initial Date:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="dd-mm-yyyy">
                </div>
                <div class="col-sm-3">
                  <label>Submition Final Date:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="dd-mm-yyyy">
                </div>
              </div>

              <div class="row">
                <div class="col-sm-3">
                  <label>Authors:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="ex: Frederico, Gratinad">
                </div>
                <div class="col-sm-3">
                  <label>Institute/University:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="ex: University of Aveiro, FEUP">
                </div>
              </div>
              <div class="row">
                <div class="col-sm-3">
                  <label>Proteins:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="ex: Frederico, Fred">
                </div>
                <div class="col-sm-3"></div>
                <div class="col-sm-1">
                  <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false"
                          style="font-size: 20px;">Filter️️</button>
                </div>
              </div>
            </div>

            <br>
            <div class="container home-question-ans">
              <div class="row question-tabs">
                <div class="col-sm-12">
                  Métodos para salvar pinheiros
                </div>
              </div>
              <div class="row">
                <div class="col-sm-12">
                  <p>As armas e os barões assinalados,
                    Que da ocidental praia Lusitana,
                    Por mares nunca de antes navegados,
                    Passaram ainda além da Taprobana,
                    Em perigos e guerras esforçados,
                    Mais do que prometia a força humana,
                    E entre gente remota edificaram
                    Novo Reino, que tanto sublimaram;
                    As armas e os barões assinalados,
                    Que da ocidental praia Lusitana,
                    Por mares nunca de antes navegados,
                    Passaram ainda além da Taprobana,
                    Em perigos e guerras esforçados,
                    Mais do que prometia a força humana,
                    E entre gente remota edificaram
                    Novo Reino, que tanto sublimaram;
                  </p>
                </div>
                <br>
              </div>
              <div class="row">
                <div class="col-sm-12">
                  <span style="font-size: 20px">Proteins associated with project:</span>
                  <br><br>
                  <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Frederico </button>
                  <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Frederico</button>
                  <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Frederico</button>
                </div>
              </div>
              <br>
              <div class="row">
                <div class="col-sm-6">
                  <span style="font-size: 20px">Members:</span>
                  <br>
                  <span class="avatar-workplace">Frederico Gratinad, Frederico Gratinad, Frederico Gratinad, Frederico Gratinad
                              </span>
                </div>
                <div class="col-sm-3">
                  <span style="font-size: 20px">Number of updates:</span>
                  <br>
                  <span class="avatar-workplace">150
                              </span>
                </div>
                <div class="col-sm-3">
                  <span style="font-size: 20px">Number of files:</span>
                  <br>
                  <span class="avatar-workplace">15
                              </span>
                </div>
              </div>
              <br>
            </div>
            <br>
            <br>
            <div class="container" style="padding-top: 1%; padding-bottom: 2%">
              <div class="row">
                <div class="col-sm-9">
                </div>
                <div class="col-sm-1">
                  <div class="center-con" style="transform: rotate(180deg)" >
                    <div class="round">
                      <div id="cta-back2" >
                        <span class="arrow primera next "></span>
                        <span class="arrow segunda next "></span>
                      </div>
                    </div>
                  </div>
                </div>
                <span style="font-family: 'Baloo Bhai', cursive;font-size: 20px; color: #4C4C4C">3</span>
                <div class="col-sm-1">
                  <div class="center-con" >
                    <div class="round">
                      <div id="cta2">
                        <span class="arrow primera next "></span>
                        <span class="arrow segunda next "></span>
                      </div>
                    </div>
                  </div>
                </div>

              </div>
            </div>
          </div>
    -->
          <div class="search-container" style="background-color: #eee; padding: 15px; margin-top: 10px">
            <div style="margin-top: 15px">
                    <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Results for: <span style="color: gray">"Frederico Gratinad"</span>
                        in <span style="color: gray">Proteins</span></span>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false"
                      style="font-size: 20px;margin-left: 10px">Hide ⬆️️</button>
            </div>
            <br>
            <div class="container filter-container" >

                    <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Search By:</span>

              <div class="row">
                <div class="col-sm-3">
                  <label>Publication Initial Date:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="dd-mm-yyyy">
                </div>
                <div class="col-sm-3">
                  <label>Publication Final Date:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="dd-mm-yyyy">
                </div>
              </div>

              <div class="row">
                <div class="col-sm-3">
                  <label>Submition Initial Date:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="dd-mm-yyyy">
                </div>
                <div class="col-sm-3">
                  <label>Submition Final Date:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="dd-mm-yyyy">
                </div>
              </div>

              <div class="row">
                <div class="col-sm-3">
                  <label>Authors:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="ex: Frederico, Gratinad">
                </div>
                <div class="col-sm-3">
                  <label>Institute/University:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="ex: University of Aveiro, FEUP">
                </div>
              </div>
              <div class="row">
                <div class="col-sm-3">
                  <label>Proteins:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px" type="text" placeholder="ex: Frederico, Fred">
                </div>
                <div class="col-sm-3"></div>
                <div class="col-sm-1">
                  <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false"
                          style="font-size: 20px;">Filter️️</button>
                </div>
              </div>
            </div>
            <br>
            <div v-for="(protein,index) in filteredProteinList" v-bind:key="index">
            <div class="container home-question-ans">
              <div class="row protein-content">
                <div class="col-sm-4">
                  <img src="../assets/images/protein_img.png" alt="Avatar" class="protein-img">
                </div>
                <div class="col-sm-8">
                            <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">{{protein.name}}</span>
                  in <span style="color: gray">Proteins</span>
                  <p>Oxytocin (Oxt) is a peptide hormone and neuropeptide. Oxytocin is normally produced in the hypothalamus and released by the posterior pituitary.[3] It plays a role in social bonding, 
                  </p>
                  <p><a href="#">more...</a></p>
                </div>
              </div>
              <div class="row">
                <div class="col-sm-12">

                </div>
                <br>

              </div>
              <div class="row">
                <div class="col-sm-4">
                  <span style="font-size: 20px">Discovered in:</span>
                  <br>
                  25-03-1996
                </div>
                <div class="col-sm-4">
                  <span style="font-size: 20px">Number of articles associated with:</span>
                  <br>
                  <span class="avatar-workplace">25
                            </span>
                </div>
                <div class="col-sm-4">
                  <span style="font-size: 20px">Number of projects associated with:</span>
                  <br>
                  <span class="avatar-workplace">25
                            </span>
                </div>
              </div>
              <br>
            </div>
            <br>
            </div>
            <div class="container" style="padding-top: 1%; padding-bottom: 2%">
              <div class="row">
                <div class="col-sm-9">
                </div>
                <div class="col-sm-1">
                  <div class="center-con" style="transform: rotate(180deg)" >
                    <div class="round">
                      <div id="cta-back2" >
                        <span class="arrow primera next "></span>
                        <span class="arrow segunda next "></span>
                      </div>
                    </div>
                  </div>
                </div>
                <span style="font-family: 'Baloo Bhai', cursive;font-size: 20px; color: #4C4C4C">3</span>
                <div class="col-sm-1">
                  <div class="center-con" >
                    <div class="round">
                      <div id="cta2">
                        <span class="arrow primera next "></span>
                        <span class="arrow segunda next "></span>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="col-sm-1">

                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <br>
    </div>
  </div>
</template>

<script>

import { mapState } from 'vuex'

export default {
  name: 'Search',
  data(){
    return{

    }
  },

  methods:{

  },

  computed:{

    ...mapState([
      'proteins'
    ]),

    listOfParams(){
      var list=[]
      console.log(this.$route.query)
      for(var param in this.$route.query){
        if(this.$route.query[param]!="false"){
          list.push(param)
        }
      }
      console.log(list);
     return  list
    },

    filteredProteinList(){
      console.log("in filtering...");
      let myfilter = this.$route.query['searchText'].toLowerCase();
      console.log(myfilter);
      console.log(this.proteins)
      return this.proteins.filter(function (protein) {
        console.log(protein)
        let protName = protein.name.toLowerCase()
        return protName.includes(myfilter)
      })
    }


  }


}
</script>

<style scoped>

</style>
