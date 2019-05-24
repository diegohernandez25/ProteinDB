export default {
  addQuestion: ({ commit }, question) => {
    commit('appendQuestion', question)
  },
  addProject: ({ commit }, project) => {
    console.log('adding')
    commit('appendProject', project)
  }
}
