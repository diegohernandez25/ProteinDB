export default {
  getUserQuestions: (state) => (uName) => {
    return state['questions'].filter(question => question.author == uName)
  },

  getIDbyQuestion: (state) => (qName) => {
    var index = -1
    let k = state['questions'].find(function (item, i) {
      if (item.title == qName) {
        index = i
        console.log('i: ', i)
        console.log('index: ', index)
        return i
      }
    })
    console.log('index: ', index)
    return index
  },
  getLoggedInUser: (state) => {
    return state['users'][0]
  },

  getIDbyUserName: (state) => (uName) => {
    console.log(state['users'])
    var index = -1
    let k = state['users'].find(function (item, i) {
      console.log(item.name)
      if (item.name == uName) {
        index = i
        return i
      }
    })
    console.log(index)
    return index
  },

  getProjecIDtByName: (state) => (pName) => {
    console.log('DEBUG!')
    var index = -1
    console.log('pName: ', pName)
    let k = state['projects'].find(function (item, i) {
      console.log('item name: ', item.name)
      if (item.name == pName) {
        index = i
        return i
      }
    })
    console.log('index: ', index)
    return index
  },

  getProjectByID: (state) => (pID) => {
    return state['projects'][pID]
  },

  getProteinByID: (state) => (prID) => {
    return state['proteins'][prID]
  },

  getMyQuestions: (state) => (userName) => {
    return state['questions'].filter(function (question) {
      return (question.author == userName)
    })
  },

  getfilteredProjectList: (state) => (filter) => {
    console.log('in filtering...')
    let myfilter = filter;
    return state['projects'].filter(function (project) { 
      let projName = project.name.toLowerCase()
      return projName.includes(myfilter)
    })
  },
  getfilteredUserList: (state) => (filter) => {
    console.log('in filtering...')
    let myfilter = filter;
    return state['users'].filter(function (user) { 
      let userName = user.name.toLowerCase()
      return userName.includes(myfilter)
    })
  },
  getfilteredProteinList: (state) => (filter) => {
    console.log('in filtering...')
    let myfilter = filter;
    return state['proteins'].filter(function (protein) { 
      let protName = protein.name.toLowerCase()
      return protName.includes(myfilter)
    })
  },

  getfilteredQuestionList: (state) => (filter) => {
    console.log('in filtering...')
    let myfilter = filter;
    return state['questions'].filter(function (question) { 
      let questTitle = quest.title.toLowerCase()
      return questTitle.includes(myfilter)
    })
  },

  getfilteredPublicationList: (state) => (filter) => {
    console.log('in filtering...')
    let myfilter = filter;
    return state['publications'].filter(function (publication) { 
      let pubName = publication.name.toLowerCase()
      return pubName.includes(myfilter)
    })
  },

}
