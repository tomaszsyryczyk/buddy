<script>	
	import Home from "./routes/home/home.svelte";
	import Stocks from "./routes/stocks/stocks.svelte";
	import Menu from "./menu/menu.svelte";
	import Button from "./controls/button/button.svelte"
	import Router from 'svelte-spa-router'
	const routes = {
		'/': Home,
		'/stocks': Stocks,
	}

	function openNav() {
		var item = document.getElementsByClassName("navigation-container")[0];
		if(item)
			item.style.width = "20%";
	}	
</script>
	<Menu />
	
	<div class="top-panel debug">
		<Button icon="fas fa-align-justify" click="{openNav}"/>
	</div>

	<div class="content debug">		
		<Router {routes}/>
	</div>

<style>
	.debug {
		border: 3px solid #000;;
	}	

	.content {
		width:90%;
		margin: auto;
		align-self: center;
	}
</style>
