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
            <a class="filter-label hide-item" style="color: #4C4C4C;padding-top: 2%;
                font-family: 'Baloo Bhai', cursive;">Chosen Filters</a>
          </div>
          <div class="hide-item" v-for="(param,index) in listOfParams" v-bind:key="index">

            <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false">❌</button>
            <span style="font-size: 20px">{{param}}</span>

          </div>

          <div v-if="$route.query.publications=='true'" class="search-container" style="background-color: #eee; padding: 15px; margin-top: 10px">
            <div style="margin-top: 15px">
                    <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Results for: <span style="color: gray">"{{$route.query.searchText}}"</span>
                        in <span style="color: gray">Publications</span></span>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false"
                      style="font-size: 20px;margin-left: 10px">Hide ⬆️️</button>
            </div>
            <br>
            <div class="container filter-container hide-item" >

                    <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Search By:</span>

              <div class="row">
                <div class="col-sm-3">
                  <label>Publication Initial Date:</label>
                </div>
                <div class="col-sm-3">
                  <input type="datetime-local" style="margin-left: 5px; width:70%" name="date">
                </div>
                <div class="col-sm-3">
                  <label>Publication Final Date:</label>
                </div>
                <div class="col-sm-3">
                  <input type="datetime-local" style="margin-left: 5px; width:70%" name="date">
                </div>
              </div>

              <div class="row">
                <div class="col-sm-3">
                  <label>Submition Initial Date:</label>
                </div>
                <div class="col-sm-3">
                  <input type="datetime-local" style="margin-left: 5px; width:70%" name="date">
                </div>
                <div class="col-sm-3">
                  <label>Submition Final Date:</label>
                </div>
                <div class="col-sm-3">
                  <input type="datetime-local" style="margin-left: 5px; width:70%" name="date">
                </div>
              </div>

              <div class="row">
                <div class="col-sm-3">
                  <label>Authors:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px; width: 70%;" type="text" placeholder="ex: Frederico, Gratinad">
                </div>
                <div class="col-sm-3">
                  <label>Institute/University:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px; width: 70%;" type="text" placeholder="ex: University of Aveiro, FEUP">
                </div>
              </div>
              <div class="row">
                <div class="col-sm-3">
                  <label>Proteins:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px; width: 70%;" type="text" placeholder="ex: Frederico, Fred">
                </div>
                <div class="col-sm-3"></div>
                <div class="col-sm-1">
                  <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false"
                          style="font-size: 20px;">Filter️️</button>
                </div>
              </div>
            </div>
             <div v-for="(pub,index) in getfilteredPublicationList($route.query['searchText'].toLowerCase())" v-bind:key="index">
              <div class="container home-question-ans">
                    <div class="row question-tabs">
                        <div class="col-sm-12">
                            {{pub.name}}
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
                            <span style="font-size: 20px">Proteins associated with publication:</span>
                            <br><br>
                            <a href="#"><span class="protein-tag"> Protein</span></a>
                            <a href="#"><span class="protein-tag"> Protein</span></a>
                            <a href="#"><span class="protein-tag"> Protein</span></a>
                            <a href="#"><span class="protein-tag"> Protein</span></a>
                            <a href="#"><span class="protein-tag"> Protein</span></a>
                        </div>
                    </div>
                    <br>
                    <div class="row">
                        <div class="col-sm-5">
                            <span style="font-size: 20px">Authors:</span>
                            <br>
                            <span class="avatar-workplace">Frederico Gratinad, Frederico Gratinad, Frederico Gratinad, Frederico Gratinad
                            </span>
                        </div>
                        <div class="col-sm-5">
                            <span style="font-size: 20px">Universities and Institutes associated to research:</span>
                            <br>
                            <span class="avatar-workplace">Universidade de Aveiro
                            </span>
                        </div>
                        <div class="col-sm-2">
                            <span style="font-size: 20px">Publication Date:</span>
                            <br>
                            <span class="avatar-workplace">25-03-1996
                            </span>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-sm-5">
                            <span style="font-size: 20px">Publication Submited by:</span>
                        </div>
                        <div class="col-sm-2">
                            <span style="font-size: 20px">Submited in:</span>
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
                            <span class="ans-date">25-03-1996</span>
                        </div>
                        <div class="col-sm-4">
                            <button style=" font-size: 130%"
                                    type="button"
                                    id="testBtn"
                                    class="btn btn-success glyphicon glyphicon-thumbs-up"
                                    data-loading-text=" ... ">👎4</button>
                            <button style="font-size: 130%; margin-left: 10%"
                                    type="button" id="testBtnDown" class="btn btn-success glyphicon glyphicon-thumbs-down" data-loading-text=" ... ">👍4</button>

                        </div>
                    </div>
                    <br>
                </div>

            <br>
            </div>
            <br>
            <br>
            <div class="container" style="padding-top: 1%; ">
              <div class="row">
                <div class="col-sm-8">
                </div>
                <div class="col-sm-1" >
                  <button v-on:click="next()" style="padding-right:30px; background-color: #00B4CC; color: white" type="button" class="btn round  side-edit-btn"><i class="fas fa-arrow-left"></i></button>
                </div>
                <div class="col-sm-1 label-text" style="text-align: center; " >
                  <span style="text-align: center; " class="label-text hide-item"><h2>1</h2></span>
                </div>
                <div class="col-sm-1"  style="width: 10%; ">
                  <button  v-on:click="prev()" style="background-color: #00B4CC; color: white; " type="button" class="btn round side-edit-btn"><i class="fas fa-arrow-right"></i></button>
                </div>
              </div>
            </div>
          </div>

          <div v-if="$route.query.project=='true'" class="search-container" style="background-color: #eee; padding: 15px; margin-top: 10px">
            <div style="margin-top: 15px">
                    <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Results for: <span style="color: gray">"{{$route.query.searchText}}"</span>
                        in <span style="color: gray">Project</span></span>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false"
                      style="font-size: 20px;margin-left: 10px">Hide ⬆️️</button>
            </div>
            <br>
            <div class="container filter-container hide-item" >

                    <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Search By:</span>

              <div class="row">
                <div class="col-sm-3">
                  <label>Publication Initial Date:</label>
                </div>
                <div class="col-sm-3">
                  <input type="datetime-local" style="margin-left: 5px; width:70%" name="date">
                </div>
                <div class="col-sm-3">
                  <label>Publication Final Date:</label>
                </div>
                <div class="col-sm-3">
                  <input type="datetime-local" style="margin-left: 5px; width:70%" name="date">
                </div>
              </div>

              <div class="row">
                <div class="col-sm-3">
                  <label>Submition Initial Date:</label>
                </div>
                <div class="col-sm-3">
                  <input type="datetime-local" style="margin-left: 5px; width:70%" name="date">
                </div>
                <div class="col-sm-3">
                  <label>Submition Final Date:</label>
                </div>
                <div class="col-sm-3">
                  <input type="datetime-local" style="margin-left: 5px; width:70%" name="date">
                </div>
              </div>

              <div class="row">
                <div class="col-sm-3">
                  <label>Authors:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px; width:70%" type="text" placeholder="ex: Frederico, Gratinad">
                </div>
                <div class="col-sm-3">
                  <label>Institute/University:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px; width:70%" type="text" placeholder="ex: University of Aveiro, FEUP">
                </div>
              </div>
              <div class="row">
                <div class="col-sm-3">
                  <label>Proteins:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px; width:70%" type="text" placeholder="ex: Frederico, Fred">
                </div>
                <div class="col-sm-3"></div>
                <div class="col-sm-1">
                  <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false"
                          style="font-size: 20px;">Filter️️</button>
                </div>
              </div>
            </div>

            <br>
            <div v-for="(proj,index) in getfilteredProjectList($route.query['searchText'].toLowerCase())" v-bind:key="index">
            <div  class="container home-question-ans">
              <div class="row question-tabs">
                <div class="col-sm-12">
                 <router-link style="color:grey" :to="`/project/${getProjecIDtByName(proj.name)}`"> {{proj.name}} </router-link>
                </div>
              </div>
              <div class="row">
                <div class="col-sm-12">
                  <p>
                    {{proj.description}}
                  </p>
                </div>
                <br>
              </div>
              <div class="row">
                <div class="col-sm-12">
                  <span style="font-size: 20px">Proteins associated with project:</span>
                  <br><br>

                  <div v-for="(protein,index) in proj.proteins" v-bind:key="index">
                     <router-link :to="`/protein/${getProteinIDtByName(protein)}`"> <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">{{protein}}</button> </router-link>
                  </div>
                </div>
              </div>
              <br>
              <div class="row">
                <div class="col-sm-6">
                  <span style="font-size: 20px">Members:</span>
                  <br>
                  <span class="avatar-workplace" v-for="(member,index) in proj.members" v-bind:key="index">{{member}},
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
            <br><br>
            </div>
            <br>
            <br>
            <div class="container" style="padding-top: 1%; ">
              <div class="row">
                <div class="col-sm-8">
                </div>
                <div class="col-sm-1" >
                  <button v-on:click="next()" style="padding-right:30px; background-color: #00B4CC; color: white" type="button" class="btn round  side-edit-btn"><i class="fas fa-arrow-left"></i></button>
                </div>
                <div class="col-sm-1 label-text" style="text-align: center; " >
                  <span style="text-align: center;" class="label-text hide-item"><h2>1</h2></span>
                </div>
                <div class="col-sm-1" >
                  <button  v-on:click="prev()" style="background-color: #00B4CC; color: white; " type="button" class="btn round side-edit-btn"><i class="fas fa-arrow-right"></i></button>
                </div>
              </div>
            </div>
          </div>

          <div v-if="$route.query.proteins=='true'" class="search-container" style="background-color: #eee; padding: 15px; margin-top: 10px">
            <div style="margin-top: 15px">
                    <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Results for: <span style="color: gray">"{{$route.query.searchText}}"</span>
                        in <span style="color: gray">Proteins</span></span>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false"
                      style="font-size: 20px;margin-left: 10px">Hide ⬆️️</button>
            </div>
            <br>
            <div class="container filter-container hide-item" >

                    <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Search By:</span>

              <div class="row">
                <div class="col-sm-3">
                  <label>Publication Initial Date:</label>
                </div>
                <div class="col-sm-3">
                  <input type="datetime-local" style="margin-left: 5px; width:70%" name="date">
                </div>
                <div class="col-sm-3">
                  <label>Publication Final Date:</label>
                </div>
                <div class="col-sm-3">
                  <input type="datetime-local" style="margin-left: 5px; width:70%" name="date">
                </div>
              </div>

              <div class="row">
                <div class="col-sm-3">
                  <label>Submition Initial Date:</label>
                </div>
                <div class="col-sm-3">
                  <input type="datetime-local" style="margin-left: 5px; width:70%" name="date">
                </div>
                <div class="col-sm-3">
                  <label>Submition Final Date:</label>
                </div>
                <div class="col-sm-3">
                  <input type="datetime-local" style="margin-left: 5px; width:70%" name="date">
                </div>
              </div>

              <div class="row">
                <div class="col-sm-3">
                  <label>Authors:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px; width:70%" type="text" placeholder="ex: Frederico, Gratinad">
                </div>
                <div class="col-sm-3">
                  <label>Institute/University:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px; width:70%" type="text" placeholder="ex: University of Aveiro, FEUP">
                </div>
              </div>
              <div class="row">
                <div class="col-sm-3">
                  <label>Proteins:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px; width:70%" type="text" placeholder="ex: Frederico, Fred">
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
                            <router-link :to="'/protein/0'" class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">{{protein.name}}</router-link>
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
            <div class="container" style="padding-top: 1%; ">
              <div class="row">
                <div class="col-sm-8">
                </div>
                <div class="col-sm-1" >
                  <button v-on:click="next()" style="padding-right:30px; background-color: #00B4CC; color: white" type="button" class="btn round  side-edit-btn"><i class="fas fa-arrow-left"></i></button>
                </div>
                <div class="col-sm-1 label-text" style="text-align: center; " >
                  <span style="text-align: center;" class="label-text hide-item"><h2>1</h2></span>
                </div>
                <div class="col-sm-1" >
                  <button  v-on:click="prev()" style="background-color: #00B4CC; color: white; " type="button" class="btn round side-edit-btn"><i class="fas fa-arrow-right"></i></button>
                </div>
              </div>
            </div>
          </div>

          <div v-if="$route.query.author=='true'" class="search-container" style="background-color: #eee; padding: 15px; margin-top: 10px">
          <div class="search-container" style="background-color: #eee; padding: 15px; margin-top: 10px">
            <div style="margin-top: 15px">
                    <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Results for: <span style="color: gray">"{{$route.query.searchText}}"</span>
                        in <span style="color: gray">Users</span></span>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false"
                      style="font-size: 20px;margin-left: 10px">Hide ⬆️️</button>
            </div>
            <br>
            <div class="container filter-container hide-item" >

                    <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Search By:</span>

              <div class="row">
                <div class="col-sm-3">
                  <label>Institute/University:</label>
                </div>
                <div class="col-sm-3">
                  <input style="margin-left: 5px; width:70%" type="text" placeholder="ex: University of Aveiro, FEUP">
                </div>
                <div class="col-sm-3"></div>
                <div class="col-sm-1">
                  <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false"
                          style="font-size: 20px;">Filter️️</button>
                </div>
              </div>
            </div>
            <br>

            <div v-for="(user,index) in getfilteredUserList($route.query['searchText'].toLowerCase())" v-bind:key="index">
              <div class="container home-question-ans">
                <div class="row">
                  <div class="col-sm-3">
                    <div class=profile-img-search >
                      <img src="../assets/images/profile.jpg" alt="">
                    </div>
                  </div>
                  <div class="col-sm-8">
                    <div class="container">
                      <div class="row">
                       <router-link :to="`/profile/${getIDbyUserName(user.name)}`" style="color:grey"> <h2 class="filter-label">{{user.name}}</h2></router-link>
                      </div>
                      <div class="row">
                        <h5 class="filter-label" style="font-size: 20px">University of Aveiro</h5>
                      </div>
                      <div class="row">
                        <router-link :to="`/profile/${getIDbyUserName(user.name)}`" > more...</router-link>
                      </div>
                      <div class="row">
                        <div class="col-sm-4">Number of Projects:</div>
                        <div class="col-sm-4">Number of Questions:</div>
                        <div class="col-sm-4">Number of Answers:</div>
                      </div>
                      <div class="row">
                        <div class="col-sm-4" style="color:gray"> {{user.projects.length}} </div>
                        <div class="col-sm-4" style="color:gray"> {{getUserQuestions(user.name).length}} </div>
                        <div class="col-sm-4" style="color:gray"> 52 </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              <br>
            </div>
            <div class="container" style="padding-top: 1%; ">
              <div class="row">
                <div class="col-sm-8">
                </div>
                <div class="col-sm-1" >
                  <button v-on:click="next()" style="padding-right:30px; background-color: #00B4CC; color: white" type="button" class="btn round  side-edit-btn"><i class="fas fa-arrow-left"></i></button>
                </div>
                <div class="col-sm-1 label-text" style="text-align: center; " >
                  <span style="text-align: center; " class="label-text hide-item"><h2>1</h2></span>
                </div>
                <div class="col-sm-1" >
                  <button  v-on:click="prev()" style="background-color: #00B4CC; color: white; " type="button" class="btn round side-edit-btn"><i class="fas fa-arrow-right"></i></button>
                </div>
              </div>
            </div>
          </div>
          </div>


           <div v-if="$route.query.question=='true'" class="search-container" style="background-color: #eee; padding: 15px; margin-top: 10px">
          <div class="search-container" style="background-color: #eee; padding: 15px; margin-top: 10px">
            <div style="margin-top: 15px">
                    <span class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                    font-family: 'Baloo Bhai', cursive;">Results for: <span style="color: gray">"{{$route.query.searchText}}"</span>
                        in <span style="color: gray">Questions</span></span>
              <button type="button" class="btn filter-buttons" aria-haspopup="true" aria-expanded="false"
                      style="font-size: 20px;margin-left: 10px">Hide ⬆️️</button>
            </div>
            <br>
            <div v-for="(question,index) in getfilteredQuestionList($route.query['searchText'].toLowerCase())" v-bind:key="index">
               <div class="container home-question-ans ">
                <div class="row question-tabs" style="padding-left: 10px">
                 <router-link :to="`/question/${getIDbyQuestion(question.title)}`" style="color:grey" > {{question.title}} </router-link>
                </div>
                <div class="row">
                    <div class="col-sm-12 text">
                        {{question.body}}
                    </div>
                </div>
                <div class="row">
                  <div class="col-sm-6">
                    <span style="font-size: 16px">Question Submited by:</span>
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
                    <router-link :to="`/profile/${getIDbyUserName(question.author)}`" class="avatar-name-ans">{{question.author}}</router-link>
                    <span class="avatar-workplace">University of Aveiro - Biologia</span>
                  </div>
                  <div class="col-sm-3">
                    <span class="ans-date" style="font-size: 15px">{{question.date}}</span>
                  </div>
                  <div class="col-sm-2">
                    <p> {{question.answers.length}} more answers</p>
                  </div>
                </div>
                <br>
              </div>
              <br>
            </div>
            <div class="container" style="padding-top: 1%; ">
              <div class="row">
                <div class="col-sm-8">
                </div>
                <div class="col-sm-1" >
                  <button v-on:click="next()" style="padding-right:30px; background-color: #00B4CC; color: white" type="button" class="btn round  side-edit-btn"><i class="fas fa-arrow-left"></i></button>
                  </div>
                <div class="col-sm-1 label-text" style="text-align: center; " >
                  <span style="text-align: center; ;" class="label-text hide-item"><h2>1</h2></span>
                </div>
                <div class="col-sm-1" >
                  <button  v-on:click="prev()" style="background-color: #00B4CC; color: white; " type="button" class="btn round side-edit-btn"><i class="fas fa-arrow-right"></i></button>
                </div>
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

import { mapState, mapGetters } from 'vuex'

export default {
  name: 'Search',
  data () {
    return {

    }
  },

  methods: {

  },

  computed: {

    ...mapState([
      'proteins'
    ]),

    ...mapGetters([
      'getfilteredProjectList',
      'getfilteredProteinList',
      'getfilteredQuestionList',
      'getfilteredUserList',
      'getProjecIDtByName',
      'getfilteredPublicationList',
      'getIDbyUserName',
      'getIDbyQuestion',
      'getUserQuestions',
      'getProteinIDtByName'
    ]),

    listOfParams () {
      var list = []
      console.log(this.$route.query)
      for (var param in this.$route.query) {
        if (this.$route.query[param] != 'false' && param != 'searchText') {
          list.push(param)
        }
      }
      console.log(list)
      return list
    },

    filteredProteinList () {
      console.log('in filtering...')
      let myfilter = this.$route.query['searchText'].toLowerCase()
      console.log(myfilter)
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

<style>
  .row {
    margin: 2px 0;
  }

  .text {

    overflow: hidden;
    word-wrap: break-word;
  }
</style>
