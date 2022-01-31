<script context="module">
  export function enumType(name, value) {
		var self = this;
		self.name = name;
		self.value = value;
	}
</script>

<script>
    export let value;
    export let types = [];
    let startingValue;
</script>

<select name="types" bind:value={value}>    
    {#each types as type}
    <option value="{type.value}">{type.name}</option>
    {/each}  
   
  </select>

<style>

</style>