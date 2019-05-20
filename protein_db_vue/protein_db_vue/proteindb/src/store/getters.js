export default{
    getUserQuestions: (state) => (uName) => {
        return state['questions'].filter(question => question.author==uName)
    },

    getIDbyQuestion: (state)=> (qName)=>{
        var index=-1
        let k= state['questions'].find(function(item, i){  
            if(item.title==qName){
                index=i;              
                return i;
            }
        })
        return index;    
    },
    getLoggedInUser: (state) => {
        return state['users'][0];
    },

    getIDbyUserName: (state) => (uName)=>{
        console.log(state['users'])
        var index=-1
        let k= state['users'].find(function(item, i){
            console.log(item.name)  
            if(item.name==uName){
                index=i;              
                return i;
            }
        })
        console.log(index)
        return index;  
    }

}