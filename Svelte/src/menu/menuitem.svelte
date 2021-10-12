<script>    
	import { Router, Route, Link } from "svelte-navigator";
    export let url;
    export let click;
    export let text;
    export let icon;

    function safeFunction(){
        if(click)
            click();
    }
</script>

<Link to="{url}" on:click="{safeFunction}"  >
    <div class="row">
        <div class="{icon} icon"></div>
        <div class="content">{text}</div>
    </div>
</Link>

<style>
    .row {        
        align-items: stretch;
        align-content: stretch;
        align-content: center;
        padding: 10px;
    }

    .row:hover {
        background-color: pink;
    }

    .content {
        margin: auto 0;
        width: 80%;
    }

    .icon {
        width: 20%;
        margin: auto 0;
    }
    
</style>