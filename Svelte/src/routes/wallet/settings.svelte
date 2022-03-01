<script>
    import { onMount } from "svelte";
    import Accordion, { Panel, Header, Content } from "@smui-extra/accordion";
    import DataTable, { Head, Body, Row, Cell } from "@smui/data-table";
    import Button, { Label, Icon } from "@smui/button";
    import NewSource from "./addingNewSource.svelte";

    import TestAsdf from "./../../api/api.svelte";

    let isAddNewOpen = false;
    $: sources = [];
    onMount(async () => {
        axios("https://localhost:5001/api/wallet/source/list").then(function (
            response
        ) {
            sources = response.data.map((x) => new row(x));
        });
    });
    function row(data) {
        var self = this;
        self.id = data.id;
        self.name = data.name;
        self.type = data.type;
        self.edit = function () {
            editSource(self);
        };
        self.delete = function () {
            removeSource(self);
        };
        return self;
    }

    function openForNewModal() {
        isAddNewOpen = !isAddNewOpen;
        TestAsdf();
    }

    function editSource(data) {
        console.log(data);
        debugger;
    }
    function removeSource(data) {
        console.log(data);
        debugger;
    }
</script>

<div class="accordion-container">
    <Accordion>
        <Panel>
            <Header>Gdzie leży hajs?</Header>
            <Content>
                <DataTable
                    table$aria-label="People list"
                    style="max-width: 100%;"
                >
                    <Head>
                        <Row>
                            <Cell>Typ</Cell>
                            <Cell>Nazwa</Cell>
                            <Cell />
                        </Row>
                    </Head>
                    <Body>
                        {#each sources as source}
                            <Row>
                                <Cell hidden>source.id</Cell>
                                <Cell>{source.type}</Cell>
                                <Cell>{source.name}</Cell>
                                <Cell>
                                    <Button on:click={source.edit()}>
                                        <Label>Edytuj</Label>
                                    </Button>
                                    <Button on:click={source.delete()}>
                                        <Label>Usuń</Label>
                                    </Button>
                                </Cell>
                            </Row>
                        {/each}
                    </Body>
                </DataTable>
                <Button on:click={() => openForNewModal()}>
                    <Icon class="material-icons">add</Icon>
                    <Label>Nowy</Label>
                </Button>
            </Content>
        </Panel>
    </Accordion>
</div>
<NewSource {isAddNewOpen} />
