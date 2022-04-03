<script>
    import DataTable, { Head, Body, Row, Cell } from "@smui/data-table";
    import LinearProgress from "@smui/linear-progress";
    import Button from "@smui/button";
    import {Api} from "./../../api-access/api.svelte";
	import { onMount } from 'svelte';

    let data = [];
    let loaded = true;

    onMount(async () => {
		loadData();
	});

    function loadData() {
        let api = new Api();
        api.get("wallet");       
    }
</script>

<DataTable table$aria-label="User list" style="width: 100%;">
    <Head>
        <Row>
            <Cell numeric>ID</Cell>
            <Cell >Name</Cell>
            <Cell>Default Value</Cell>
            <Cell>From</Cell>
            <Cell>To</Cell>
        </Row>
    </Head>
    <Body>
        {#each data as item (item.id)}
            <Row>
                <Cell numeric>{item.id}</Cell>
                <Cell>{item.name}</Cell>
                <Cell>{item.username}</Cell>
                <Cell>{item.email}</Cell>
            </Row>
        {/each}
    </Body>

    <LinearProgress
        indeterminate
        bind:closed={loaded}
        aria-label="Data is being loaded..."
        slot="progress"
    />
</DataTable>
