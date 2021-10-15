<script>	
	import Home from "./routes/home/home.svelte";
	import HistoryStocks from "./routes/stocks/history/history.svelte";
	import CurrentStocks from "./routes/stocks/current/current.svelte";
	import NotFound from "./routes/NotFound/notfound.svelte";
	import Menu from "./menu/menu.svelte";
	import Button from "./controls/button/button.svelte"
	import Router from 'svelte-spa-router'
	const routes = {
		'/': Home,
		'/stocks/current': CurrentStocks,
		'/stocks': CurrentStocks,
		'/stocks/history': HistoryStocks,
		'*': NotFound
	}

	function openNav() {
		var item = document.getElementsByClassName("navigation-container")[0];
		if(item)
			item.style.width = "20%";
	}	
</script>
	<Menu />
	
	<div class="row col-xs-1">
		<Button icon="fas fa-align-justify" click="{openNav}"/>
	</div>	
	<Router {routes}/>

<style>
</style>
