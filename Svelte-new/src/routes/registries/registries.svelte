<script>
    import DataTable, { Head, Body, Row, Cell } from "@smui/data-table";
    import Button from "@smui/button";
    import { onMount } from "svelte";
    import CreateDialog from "./dialog-create.svelte";
    import EditDialog from "./dialog-edit.svelte";
    import DeleteDialog from "./dialog-delete.svelte";
    import CurrencyText from "../../components/currency/currencyText.svelte";
    import {dateInShowFormat,dateInInputFormat} from "./../../components/consts.svelte";
    import Chip, { Set, Text } from '@smui/chips';
    import { Api } from "./../../api-access/api.svelte";
    let api = new Api();

    export let from = moment().add(-1,'months');
    export let to = moment();

    let data = [];
    let createDialog;
    let editDialog;
    let deleteDialog;

    onMount(async () => {
        refresh();
    });

    function refresh() {
        all();
    }

    function dataLoaded(response) {
        data = response.data.registries.map(Registry);
    }

    function all() {
        let data = new Search(from,to);
        debugger;
        api.get("registry/list", data,dataLoaded);
    }

    function create() {
        createDialog.openDialog();
    }

    function edit(id) {
        editDialog.openDialog(id);
    }

    function remove(id) {
        deleteDialog.openDialog(id);
    } 
    
    function Search(from, to){
        let self = this;
        self.from = dateInInputFormat(from);
        self.to = dateInInputFormat(to);
    }

    function Registry(row) {
        let self = new Object();
        self.id = row.id;
        self.amount = row.amount;
        self.name = row.name;
        self.when = row.when;
        self.type = row.type;
        self.category = ['test1','test2','test3','test11','test22','test33','test12','test222','test32']
        self.isIncome = function () {
            if (self.type == "Income") {
                return true;
            }
            return false;
        };

        return self;
    }
</script>

<Button on:click={create} variant="raised">Add</Button>
<DataTable table$aria-label="User list" style="width: 100%;">
    <Head>
        <Row>
            <Cell numeric>Amount</Cell>
            <Cell datetime>Date</Cell>
            <Cell>Name</Cell>
            <Cell>Category</Cell>
            <Cell />
        </Row>
    </Head>
    <Body>
        {#each data as item (item.id)}
            <Row>
                <Cell numeric>
                    <CurrencyText value={item.amount} currencyUnit="zł" isPositive="{item.isIncome()}" />
                </Cell>
                <Cell>{dateInShowFormat(item.when)}</Cell>
                <Cell>{item.name}</Cell>
                <Cell><Set chips={item.category} let:chip nonInteractive>
                    <Chip {chip}>
                      <Text>{chip}</Text>
                    </Chip>
                  </Set></Cell>
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
