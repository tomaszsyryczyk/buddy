<script>
    import Dialog, { Content, Actions, Title } from "@smui/dialog";
    import Button, { Label } from "@smui/button";
    import Textfield from "@smui/textfield";
    import { Api } from "./../../api-access/api.svelte";
    import {dateInShowFormat} from "./../../components/consts.svelte";

    let api = new Api();
    let open = false;
    let data = new Create();

    function save() {
        api.delete("registry/" + data.id, null, function () {
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
            self.when = data.when;
            self.type = data.type;
        }
    }

    export let callback;

    export function openDialog(id) {
        api.get("registry/" + id, function (response) {
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
    <Title id="simple-title">Are you sure you want to remove it?</Title>
    <Content id="slider-content">
        <Textfield disabled variant="filled" value={dateInShowFormat(data.when)} label="When" />
        <Textfield disabled variant="filled" value={data.type} label="Type"/>
        <Textfield disabled variant="filled" value={data.amount} label="Amount" />
        <Textfield disabled variant="filled" value={data.name} label="Name" />
    </Content>
    <Actions>
        <Button on:click={closeDialog}>
            <Label>Cancel</Label>
        </Button>
        <Button on:click={save} action="accept">
            <Label>Delete</Label>
        </Button>
    </Actions>
</Dialog>
