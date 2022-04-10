<script context="module">
    export function dateInShowFormat(data){
        return moment(data).format("DD/MM/YYYY");
    }

    export function dateInInputFormat(data){
        return moment(data).format("YYYY/MM/DD");
    }
</script>