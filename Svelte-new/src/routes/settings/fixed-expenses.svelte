<script>
    import DataTable, { Head, Body, Row, Cell } from "@smui/data-table";
    import LinearProgress from "@smui/linear-progress";
    import Button from "@smui/button";
    import { Api } from "./../../api-access/api.svelte";
    import { onMount } from "svelte";
    import FixedExpensesDialog, {CreateFixedExpense} from "./fixed-expenses-dialog.svelte";

    let data = [];
    let loaded = true;
    let newFixedExpense = {};
    let api = new Api();

    onMount(async () => {
        loadData();
    });

    function loadData() {        
        api.get("settings/fixed-expenses/all", dataLoaded);
    };

    function dataLoaded(response) {
        data = response.data;
    };

    function createNew(){
        newFixedExpense = new CreateFixedExpense();
    }

    function edit(id){
        let response = api.get("settings/fixed-expenses/" + id);
        newFixedExpense = new CreateFixedExpense(response.data);
    }

</script>

<Button variant="raised">Add</Button>
<DataTable table$aria-label="User list" style="width: 100%;">
    <Head>
        <Row>
            <Cell hidden>ID</Cell>
            <Cell>Name</Cell>
            <Cell>Value</Cell>
            <Cell />
        </Row>
    </Head>
    <Body>
        {#each data as item (item.id)}
            <Row>
                <Cell hidden>{item.id}</Cell>
                <Cell>{item.name}</Cell>
                <Cell>{item.value}</Cell>
                <Cell>
                    <Button variant="raised">Edit</Button>
                    <Button variant="raised">Delete</Button>
                </Cell>
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

<FixedExpensesDialog data={newFixedExpense}  />
