<script >
    import Accordion, { Panel, Header, Content } from '@smui-extra/accordion';
    import Accounts from "./accounts/accounts.svelte";
    import Wallets from "./wallets/wallets.svelte";
 </script>

<Accordion>
    <Panel >
        <Header ripple={false}>Portfele</Header>
        <Content><Wallets/></Content>
    </Panel>

    <Panel open>
        <Header ripple={false}>Konta</Header>
        <Content><Accounts/></Content>
    </Panel>    
    
</Accordion>