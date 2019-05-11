<template>
  <div id="app">
    {{message}}
    <user-name name="Diego"></user-name>
    <user-name name="Flavio"></user-name>
    <user-name name="Roger"></user-name>
    <user-name name="Syd"></user-name>
  </div>
</template>

<script>
export default {
  name: 'index',
  data () {
    return {
      message: 'Olá Diego.'
    }
  }
}
</script>

<style scoped>

</style>
