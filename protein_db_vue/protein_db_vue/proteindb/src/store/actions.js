export default {
   addQuestion: ({commit}, question) => {
       commit('appendQuestion',question)
   }
}