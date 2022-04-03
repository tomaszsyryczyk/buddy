<script>
    import DataTable, { Head, Body, Row, Cell } from "@smui/data-table";
    import LinearProgress from "@smui/linear-progress";
    import Button from "@smui/button";
    import { Api } from "./../../api-access/api.svelte";
    import { onMount } from "svelte";
    import FixedExpensesDialog, {CreateFixedExpense} from "./fixed-expenses-dialog.svelte";
    import FixedExpensesApi from "./fixed-expenses.api.svelte";

    let fixedExpensesApi = new FixedExpensesApi();
    let data = [];
    let loaded = true;
    let newFixedExpense = {};
    let api = new Api();
    let modalOpen = {};
    let successAction = null;

    onMount(async () => {
        all();
    });

    function all() {        
        api.get("settings/fixed-expenses/all", dataLoaded);
    };

    function dataLoaded(response) {
        data = response.data;
    };

    function create(){
        newFixedExpense = new CreateFixedExpense();
        successAction = createCommit;
    }

    function createCommit(){
        api.put("settings/fixed-expenses/", newFixedExpense, function(){
            all();
        });
    }

    function edit(id){
        api.get("settings/fixed-expenses/" + id, function(response){
            newFixedExpense = new CreateFixedExpense(response.data);
            successAction = editCommit;
        });        
    }

    function editCommit(){
        api.post("settings/fixed-expenses/"+newFixedExpense.id, newFixedExpense, function(){
            all();
        });
    }

    function remove(id){
        api.get("settings/fixed-expenses/" + id, function(response){
            newFixedExpense = new CreateFixedExpense(response.data);
            successAction = removeCommit;
        });  
    };

    function removeCommit(){
        api.delete("settings/fixed-expenses/"+newFixedExpense.id, null, function(){
            all();
        });
    }

</script>

<Button on:click={create} variant="raised">Add</Button>
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
                    <Button on:click={edit(item.id)} variant="raised">Edit</Button>
                    <Button on:click={remove(item.id)} variant="raised">Delete</Button>
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

<FixedExpensesDialog bind:open={modalOpen} bind:data={newFixedExpense} successAction={successAction} />
