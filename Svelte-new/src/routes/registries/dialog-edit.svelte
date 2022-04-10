<script>
    import Dialog, { Content, Actions, Title } from "@smui/dialog";
    import Button, { Label } from "@smui/button";
    import Textfield from "@smui/textfield";
    import { Api } from "./../../api-access/api.svelte";
    import Autocomplete from '@smui-extra/autocomplete';
    import {dateInInputFormat} from "./../../components/consts.svelte";

    let api = new Api();
    let open = false;
    let data = new Create();
    let types = ['Income', 'Expense'];

    function save() {
        api.post("registry/" + data.id, data, function () {
            closeDialog();
            callback();
        });
    }

    function Create(data) {
        let self = this;
        self.id = 0;
        self.name = '';
        self.amount = 0;
        self.when = '';
        self.type = '';
        if (data) {
            self.id = data.id;
            self.name = data.name;
            self.amount = data.amount;
            self.when = dateInInputFormat(data.when);
            self.type = data.type;
        }
    }

    export let callback;

    export function openDialog(id) {
        api.get("registry/" + id, function (response) {
            debugger;
            data = new Create(response.data);
            open = true;
        });
    }

    export function closeDialog() {
        open = false;
    }
</script>

<Dialog
    bind:open
    aria-labelledby="slider-title"
    aria-describedby="slider-content"
>   
    <Title id="simple-title">Edit</Title>
    <Content id="slider-content">
        <Textfield type="date" variant="filled" bind:value={data.when} label="When" />
        <Autocomplete options={types} variant="filled" bind:value={data.type} label="Type"/>
        <Textfield type="number" variant="filled" bind:value={data.amount} label="Amount" />
        <Textfield variant="filled" bind:value={data.name} label="Name" />
    </Content>
    <Actions>
        <Button on:click={closeDialog}>
            <Label>Cancel</Label>
        </Button>
        <Button on:click={save} action="accept">
            <Label>Accept</Label>
        </Button>
    </Actions>
</Dialog>
