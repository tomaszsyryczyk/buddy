<script>
	import Home from "./routes/home/home.svelte";
	import HistoryStocks from "./routes/stocks/history/history.svelte";
	import CurrentStocks from "./routes/stocks/current/current.svelte";
	import NotFound from "./routes/NotFound/notfound.svelte";
	import Menu from "./menu/menu.svelte";
	import Router from "svelte-spa-router";
	import MainBar from "./main-bar/main-bar.svelte";
	import Wallet from "./routes/wallet/wallet.svelte";
	const routes = {
		"/": Home,
		"/stocks/current": CurrentStocks,
		"/stocks": CurrentStocks,
		"/stocks/history": HistoryStocks,
		"/wallet": Wallet,
		"*": NotFound,
	};

	const menus = [
		new menuItem("HOME", "/", "fa-home"),
		new menuItem("Stocks", "/stocks", "fa-chart-line"),
		new menuItem("Łolet", "/wallet", "fa-wallet"),
	];

	function menuItem(name, url, icon) {
		var self = this;
		self.name = name;
		self.url = url;
		self.icon = icon;
	}

	function openNav() {
		var item = document.getElementsByClassName("navigation-container")[0];
		if (item) item.style.width = "20%";
	}
</script>

<div class="app">
	<div class="main-bar">
		<MainBar />
	</div>

	<div class="nav">
		<Menu {menus} />
	</div>

	<div class="content">
		<Router {routes} />
	</div>
</div>

<style>
	.app {
		display: grid;
		grid-gap: 0;
		grid-template-columns: 5em 1fr;
		grid-template-rows: 2em 1fr;
		margin: 0;
		height: 100%;
		grid-template-areas:
			"header header"
			"nav content";
	}

	.main-bar {
		background-color: black;
		color: white;
		grid-area: header;
		z-index: 9999;
	}

	.nav {
		grid-area: nav;
		z-index: 1000;
	}

	.content {
		grid-area: content;
		z-index: 0;
	}
</style>
