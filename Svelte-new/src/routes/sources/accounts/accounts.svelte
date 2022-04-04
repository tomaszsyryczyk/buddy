<script>
    import DataTable, { Head, Body, Row, Cell } from "@smui/data-table";
    import Button from "@smui/button";
    import { onMount } from "svelte";
    import CreateDialog from "./dialog-create.svelte";
    import EditDialog from "./dialog-edit.svelte";
    import DeleteDialog from "./dialog-delete.svelte";

    import { Api } from "./../../../api-access/api.svelte";
    let api = new Api();

    let data = [];
    let createDialog;
    let editDialog;
    let deleteDialog;

    onMount(async () => {
        refresh();
    });

    function refresh(){
        all();
    }

    function dataLoaded(response) {
        data = response.data.accounts;
    }

    function all() {
        api.get("settings/accounts/all", dataLoaded);
    }

    function create(){
        createDialog.openDialog();
    }

    function edit(id){
        editDialog.openDialog(id);
    }

    function remove(id){
        deleteDialog.openDialog(id);
    }

</script>

<Button on:click={create} variant="raised">Add</Button>
<DataTable table$aria-label="User list" style="width: 100%;">
    <Head>
        <Row>
            <Cell hidden>ID</Cell>
            <Cell>Name</Cell>
            <Cell numeric>IBAN</Cell>
            <Cell />
        </Row>
    </Head>
    <Body>
        {#each data as item (item.id)}
            <Row>
                <Cell hidden>{item.id}</Cell>
                <Cell>{item.name}</Cell>
                <Cell numeric>{item.iban}</Cell>
                <Cell>
                    <Button on:click={edit(item.id)} variant="raised"
                        >Edit</Button
                    >
                    <Button on:click={remove(item.id)} variant="raised"
                        >Delete</Button
                    >
                </Cell>
            </Row>
        {/each}
    </Body>
</DataTable>
<CreateDialog bind:this={createDialog} callback={refresh} />
<EditDialog bind:this={editDialog} callback={refresh} />
<DeleteDialog bind:this={deleteDialog} callback={refresh} />