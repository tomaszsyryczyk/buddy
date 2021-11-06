<script>	
	import Home from "./routes/home/home.svelte";
	import HistoryStocks from "./routes/stocks/history/history.svelte";
	import CurrentStocks from "./routes/stocks/current/current.svelte";
	import NotFound from "./routes/NotFound/notfound.svelte";
	import Menu from "./menu/menu.svelte";
	import Router from 'svelte-spa-router'
	const routes = {
		'/': Home,
		'/stocks/current': CurrentStocks,
		'/stocks': CurrentStocks,
		'/stocks/history': HistoryStocks,
		'*': NotFound
	}

	const menus = [		
		new menuItem("HOME","/","fa-home"),
		new menuItem("Stocks","/stocks","fa-chart-line"),
		new menuItem("HOME","/","fa-home"),
		new menuItem("Stocks","/stocks","fa-chart-line"),
	]

	function menuItem(name, url, icon){
		var self = this;
		self.name = name;
		self.url = url;
		self.icon = icon;
	}
	
	function openNav() {
		var item = document.getElementsByClassName("navigation-container")[0];
		if(item)
			item.style.width = "20%";
	}	
</script>

<Menu {menus} />

<div class="content">
	<Router {routes}/>
</div>

<style>
	.content {
		margin:0 5em;
	}
</style>
