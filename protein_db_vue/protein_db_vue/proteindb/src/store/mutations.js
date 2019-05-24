export default {
  appendQuestion: (state, question) => {
    state['questions'].push(question)
  },

  appendProject: (state, project) => {
    state['projects'].push(project)
  }
}
