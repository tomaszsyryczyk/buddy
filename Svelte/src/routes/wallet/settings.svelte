<script>
    import { onMount } from "svelte";
    import Accordion, { Panel, Header, Content } from "@smui-extra/accordion";
    import DataTable, { Head, Body, Row, Cell } from "@smui/data-table";
    import Button, { Label, Icon } from "@smui/button";
    import NewSource from "./addingNewSource.svelte";
    let isAddNewOpen = false;
    $: sources = [];
    onMount(async () => {
        axios('https://localhost:5001/api/wallet/source/list')
            .then(function (response) {
                sources = response.data.map(row);
            });
    });
    function row(data){
        var self = this;
        self.id = data.id;
        self.name = data.name;
        self.type = data.type;        
        return self;
    }

    function openForNewModal() {
        isAddNewOpen = !isAddNewOpen;
    };

    function edit(source) {debugger;};
    function remove(source) {debugger;};
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
                                <Cell>source.type</Cell>
                                <Cell>source.name</Cell>
                                <Cell>
                                    <Button on:click={(source) => edit(source)}>
                                        <Label>Edytuj</Label>
                                    </Button>
                                    <Button on:click={(source) => remove(source)}>
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
