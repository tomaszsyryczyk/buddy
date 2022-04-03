<script context="module">
    export function CreateFixedExpense(item) {
        let self = this;
        self.id = 0;
        self.name = "";
        self.value = 0;
        if (item) {
            self.id = item.id;
            self.name = item.name;
            self.value = item.value;
        }
    }
</script>

<script>
</script>
