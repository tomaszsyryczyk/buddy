<script context="module">
    let BASE_API_URL = "https://localhost:5001/api/";

    axios.defaults.baseURL = BASE_API_URL;
    axios.defaults.headers.common['Access-Control-Allow-Origin'] = "*";
    //axios.defaults.headers.post['Content-Type'] = 'application/x-www-form-urlencoded';

    // const instance = axios.create({
    //     baseURL: BASE_API_URL,
    //     timeout: 1000 * 60 * 10,
    //     headers: {
    //         "Access-Control-Allow-Origin": "*",
    //     },
    // });

    function httpGet(url) {
        debugger;
        axios
            .get(url)
            .catch(function (error) {
                debugger;
                console.log("Show error notification!");
                return Promise.reject(error);
            })
            .then(function (e) {
                debugger;
            });
    }

    function httpPost(url, data) {}

    function httpPut(url, data) {}

    function httpDelete(url, data) {}

    export function Api() {
        var self = this;
        self.post = httpPost;
        self.get = httpGet;
        self.put = httpPut;
        self.delete = httpDelete;
    }
</script>
