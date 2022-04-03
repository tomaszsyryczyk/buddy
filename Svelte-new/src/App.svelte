<script>
	import Router from "svelte-spa-router";
	import MainBar from "./main-bar/main-bar.svelte";
	import Menu ,{menuItem} from "./menu/menu.svelte";	
	import NotFound from "./routes/not-found/not-found.svelte";
	import Settings from "./routes/settings/settings.svelte";
	import FixedExpenses from "./routes/settings/fixed-expenses.svelte";

	const routes = {
		"/settings" : Settings,
		"/settings/fixed-expenses" : FixedExpenses,
		"*": NotFound,
	};

	const menus = [
		new menuItem("settings", "/settings", "fa-cogs"),
		new menuItem("Wydatki stałe", "/settings/fixed-expenses", ""),
	];

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

	asdf
</div>

<style>
	.app {
		display: grid;
		grid-gap: 0;
		grid-template-columns: 10em 1fr;
		grid-template-rows: 5em 1fr;
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
		padding: 1em;
	}
</style>