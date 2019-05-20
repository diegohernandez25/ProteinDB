<template>
<div id ="protein">
  <div class="container">
    <div class="row">
      <h1 style="color: grey">Protein Name</h1>
    </div>
    <div class="row">
      <div class="col-sm-4">
        <div class=protein-profile-img >
          <img src="../assets/images/protein_img.png" alt="">
        </div>
      </div>
      <div class="col-sm-8">
        <h2 style="color: grey"> Simplified Name:</h2> name <br>
        <h2 style="color: grey"> Family:</h2> name of the family <br>
        <h2 style="color: grey"> Gene:</h2> name of the gene.<br>
        <p>AS armas e os Barões assinalados
          Que da Ocidental praia Lusitana
          Por mares nunca de antes navegados
          Passaram ainda além da Taprobana,
          Mais do que prometia a força humana,
          Em perigos e guerras esforçados
          E entre gente remota edificaram
          Novo Reino, que tanto sublimaram;
          Que da Ocidental praia Lusitana
          Por mares nunca de antes navegados
          Passaram ainda além da Taprobana,
          Mais do que prometia a força humana,
          Em perigos e guerras esforçados
          E entre gente remota edificaram
          Novo Reino, que tanto sublimaram;
        </p>
      </div>
    </div>
    <div class="row" style="padding-top: 10px">
      <h2 style="color: grey">Interacts with:</h2>
    </div>
    <div class="row" >
      <div>
        <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Protein 1</button>
        <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Protein 2</button>
        <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Protein 3</button>
        <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Protein 4</button>
        <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Protein 5</button>
        <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Protein 6</button>
        <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Protein 7</button>
      </div>
    </div>
    <div class="row" style="padding-top: 10px">
      <h2 style="color: grey">Species</h2>
    </div>
    <div class="row">
      <div>
        <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Specie 1</button>
        <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Specie 2</button>
        <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Specie 3</button>
        <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Specie 4</button>
        <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Specie 5</button>
      </div>
    </div>
    <div class="row" style="padding-top: 10px">
      <h2 style="color: grey">Diseases:</h2>
    </div>
    <div class="row">
      <div>
        <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Disease 1</button>
        <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Disease 2</button>
        <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false">Disease 3</button>
      </div>
    </div>
    <div class="row" style="padding-top: 10px">
      <h2 style="color: grey">Functions:</h2>
    </div>
    <div class="row">
      <p>As armas e os barões assinalados,
        Que da ocidental praia Lusitana,
        Por mares nunca de antes navegados,
        Passaram ainda além da Taprobana,
        Em perigos e guerras esforçados,
        Mais do que prometia a força humana,
        E entre gente remota edificaram
        Novo Reino, que tanto sublimaram;As armas e os barões assinalados,
        Que da ocidental praia Lusitana,
        Por mares nunca de antes navegados,
        Passaram ainda além da Taprobana,
        Em perigos e guerras esforçados,
        Mais do que prometia a força humana,
        E entre gente remota edificaram
        Novo Reino, que tanto sublimaram;As armas e os barões assinalados,
        Que da ocidental praia Lusitana,
        Por mares nunca de antes navegados,
        Passaram ainda além da Taprobana,
        Em perigos e guerras esforçados,
        Mais do que prometia a força humana,
        E entre gente remota edificaram
        Novo Reino, que tanto sublimaram;
        Novo Reino, que tanto sublimaram;As armas e os barões assinalados,
        Que da ocidental praia Lusitana,
        Por mares nunca de antes navegados,
        Passaram ainda além da Taprobana,
        Em perigos e guerras esforçados,
        Mais do que prometia a força humana,
        E entre gente remota edificaram
        Novo Reino, que tanto sublimaram;As armas e os barões assinalados,
        Que da ocidental praia Lusitana,
        Por mares nunca de antes navegados,
        Passaram ainda além da Taprobana,
        Em perigos e guerras esforçados,
        Mais do que prometia a força humana,
        E entre gente remota edificaram
        Novo Reino, que tanto sublimaram;</p>
    </div>
    <div>
      <b-tabs content-class="mt-3">
        <b-tab @click="tabIndex=0; resetIndex()" title="Publications" active>
          <div class="container" style="padding:50px">
            <div id='Most_Viewed_Questions' class="tab-content padding-grey-area">
              <div class="container filter-container"  >
                      <h3 class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                      font-family: 'Baloo Bhai', cursive;">Search By:</h3>
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
                    <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false"
                            style="font-size: 20px;">Filter️️</button>
                  </div>
                </div>
              </div>
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
            </div>
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
            </div>
          </div>
        </b-tab>
        <b-tab @click="tabIndex=1; resetIndex()" title="Projects">
          <div id='Not_Answered' class="tab-content">
            <div class="container" style="padding:50px">
              <div class="container filter-container"  >
                <h3 class="filter-label" style="color: #4C4C4C;padding-top: 2%;
                        font-family: 'Baloo Bhai', cursive;">Search By:</h3>
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
                    <button type="button" class="btn protein-buttons" aria-haspopup="true" aria-expanded="false"
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
            </div>
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
            </div>
          </div>
        </b-tab>
        <br>
        <br>
      </b-tabs>
    </div>
  </div>
</div>

</template>

<script>
export default {
  name: 'Protein'
}
</script>

<style scoped>

</style>
