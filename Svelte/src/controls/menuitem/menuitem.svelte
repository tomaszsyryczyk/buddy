<script>    
	import { Router, Route, Link } from "svelte-navigator";
    export let url;
    export let click;
    export let text;

    function safeFunction(){
        if(click)
            click();
    }
</script>

<Link to="{url}" on:click="{safeFunction}" >
    <div class="icon"></div>
    <div class="content">{text}</div>
</Link>