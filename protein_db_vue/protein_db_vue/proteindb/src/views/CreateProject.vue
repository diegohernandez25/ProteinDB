<template>
  <div class="container">
    <b-alert v-model="showDismissibleAlert" variant="danger" dismissible>
            Name and Privacy have to have a value
            </b-alert>
      <b-alert v-model="showDismissibleAlert2" variant="danger" dismissible>
            New member has to have a name and a role
            </b-alert>
    <b-form v-if="show">
      <b-form-group
        id="input-group-1"
        label="*Name of the project:"
        label-for="input-1"
        description="Name of the project must be unique among your projects"
      >
        <b-form-input
          id="input-1"
          v-model="form.name"
          placeholder="Enter name of the project"
        ></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-2">
        <div class="row">
          <div class="col-sm-8">
            <b-form-group label="Add Members:" label-for="input-2">
                  <b-form-input
                    id="input-2"
                    v-model="currentMember"
                    placeholder="Enter name or e-mail of members"></b-form-input>
            </b-form-group>
          </div>
          <div class="col-sm-3">
            <b-form-group label="Role:" label-for="input-3">
              <b-form-select
                id="input-3"
                v-model="role"
                :options="roles"
              ></b-form-select>
            </b-form-group>
          </div>
          <div class="col-sm-1" style="margin-top: 10px">
            <button @click="addMember" type="button" class="btn add-button" aria-haspopup="true" aria-expanded="false"
                    style="font-size: 20px;">Add️️</button>
          </div>
        </div>
      </b-form-group>
      <b-form-group id="input-group-new-1" label="Register proteins associated with the project:" label-for="input-2">
        <b-form-input
          id="input-new-1"
          v-model="form.proteins"
          placeholder="Enter name of proteins associated with the project"
        ></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-3" label="*Privacy:" label-for="input-3">
        <b-form-select
          id="input-3"
          v-model="form.priv"
          :options="privL"

        ></b-form-select>

      </b-form-group>

      <b-button @click="onSubmit" class="add-button">Submit</b-button>
    </b-form>

    <br>
        *Mandatory Fields



    <br>
    <br>
    <h2>Added Members</h2>
    <div class="mem" v-for="(member,index) in form.members" v-bind:key="index">
      <img src="../assets/images/profile.jpg" alt=""> <br>
      <p>{{member}}</p>
    </div>
  </div>
</template>

<script>

import { mapActions, mapGetters } from 'vuex'
export default {
  data () {
    return {
      showDismissibleAlert: false,
      showDismissibleAlert2: false,
      currentMember: '',
      role: '',
      form: {
        name: '',
        // members: [{name:"o", role:""}],
        members: ['Frederico'],
        proteins: '',
        priv: ''

      },
      privL: [ 'Private', 'Public'],
      roles: [ 'Manager', 'Member'],
      show: true
    }
  },

  methods: {
    ...mapActions([
      'addProject'
    ]),

    onSubmit () {
      if (this.form.name == '' || this.form.privacy == '') {
        this.showDismissibleAlert=true
      } else {
        let payload = {
          name: this.form.name,
          description: '',
          manager: 'Frederico',
          members: this.form.members,
          institute: 'Universidade de Aveiro',
          favourites: 0,
          updates: 0,
          articles: [],
          creationDate: '01-01-2019',
          privacy: this.form.priv
        }
        console.log('Payload: ', payload);
        console.log('Project name:', payload.name)
        this.addProject(payload)

        let nameP=payload.name;
        let projId =  this.getID
        console.log(projId)
        this.currentMember = ''
        this.role = ''
        this.form.name = ''
        this.form.members = ['Frederico']
        this.form.proteins = ''
        this.form.priv = ''
        this.$router.replace('/project/' + projId)
      }
    },

    addMember () {
      if (this.currentMember == '' || this.role == '') {
        this.showDismissibleAlert2=true
      } else {
        // this.form.members.push({name: this.currentMember, role:this.role})
        this.form.members.push(this.currentMember)
        this.currentMember = ''
        this.role = ''
      }
    }
  },

  computed:{
     ...mapGetters([
      'getProjecIDtByName'
    ]),

    getID: {
    // getter
    get: function () {
      console.log(this.getProjecIDtByName(this.form.name));
      return this.getProjecIDtByName(this.form.name);
    },
  }
}
}
</script>

<style scoped>

.red{
  border: 2px solid red;
}

.mem{
  margin: 10px;
  display:inline-flex;
  flex-direction: column;
}

.mem > img{
  flex:0;
  align-self: start;
  border-radius: 50%;
}

.mem > p{
  flex:0;
  align-self: center
}

</style>
