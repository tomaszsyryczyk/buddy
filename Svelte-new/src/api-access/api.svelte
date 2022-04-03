<script context="module">
    let Url = "https://localhost";
    function Api(){
        var self = this;
        self.getSimpleData = getSimpleData;

    };

    function getSimpleData(){
        console.log("done");
    }

    export let apiModule = new Api();    
</script>