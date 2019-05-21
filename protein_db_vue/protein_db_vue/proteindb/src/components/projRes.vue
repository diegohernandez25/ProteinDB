<template>
    <div class="result-item">
        <div>
            <h2>{{project.name}}</h2>
            <div>
                    {{project.favourites}} <i class="fas fa-star" style="color: rgba(255, 217, 0, 0.993);"></i>
                </div>
                <div>
                    {{project.updates}} Updates
                </div>
                <div>
                    {{project.articles.length}} Articles
                </div>
                <div>
                    <button type="button" class="btn add-button"><i class="fas fa-pencil-alt"></i></button>
                </div>
        </div>
        <div>
            <p>{{project.description}}</p>
        </div>
        <div class="item-attributes">
                <b>Project Manager:</b> {{project.manager}} <br>
                <b>Institute:</b> {{project.institute}}
        </div>
    </div>
</template>

<script>


import {mapState} from 'vuex'

export default {
    name: 'questionPrev',
    props: {
        project: Object
    },

    computed: {
    ...mapState([

    ]),


    }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style>

</style>
