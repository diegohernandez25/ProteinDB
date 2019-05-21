<template>
  <div class="container">
    <b-form @submit="onSubmit" @reset="onReset" v-if="show">
      <b-form-group
        id="input-group-1"
        label="Name of the project:"
        label-for="input-1"
        description="Name of the project must be unique among your projects"
      >
        <b-form-input
          id="input-1"
          v-model="form.email"
          type="email"
          required
          placeholder="Enter name of the project"
        ></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-2" label="Add Members:" label-for="input-2">
        <div class="row">
          <div class="col-sm-8">
            <b-form-input
              id="input-2"
              v-model="form.name"
              required
              placeholder="Enter name or e-mail of members"
            ></b-form-input>
          </div>
          <div class="col-sm-3">
              <b-form-select
                id="input-4"
                v-model="form.food"
                :options="usermod"
                required
              ></b-form-select>
          </div>
          <div class="col-sm-1">
            <button type="button" class="btn add-button" aria-haspopup="true" aria-expanded="false"
                    style="font-size: 20px;">Add️️</button>
          </div>
        </div>
      </b-form-group>

      <b-form-group id="input-group-new-1" label="Register proteins associated with the project:" label-for="input-2">
        <b-form-input
          id="input-new-1"
          v-model="form.protein"
          required
          placeholder="Enter name of proteins associated with the project"
        ></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-3" label="Privacy:" label-for="input-3">
        <b-form-select
          id="input-3"
          v-model="form.food"
          :options="foods"
          required
        ></b-form-select>
      </b-form-group>
      <b-button type="submit" variant="primary" class="add-button">Submit</b-button>
    </b-form>
  </div>
</template>

<script>
export default {
  data () {
    return {
      form: {
        email: '',
        name: '',
        food: null,
        checked: []
      },
      foods: [{ text: 'Choose privacy', value: null }, 'Private', 'Public'],
      usermod: [{ text: 'Choose role', value: null }, 'Manager', 'Member'],
      show: true
    }
  },
  methods: {
    onSubmit (evt) {
      evt.preventDefault()
      alert(JSON.stringify(this.form))
    },
    onReset (evt) {
      evt.preventDefault()
      // Reset our form values
      this.form.email = ''
      this.form.name = ''
      this.form.food = null
      this.form.checked = []
      // Trick to reset/clear native browser form validation state
      this.show = false
      this.$nextTick(() => {
        this.show = true
      })
    }
  }
}
</script>

<style scoped>

</style>
