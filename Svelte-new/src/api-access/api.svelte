<script context="module">
    let BASE_API_URL = "https://localhost:5001/api/";

    axios.defaults.baseURL = BASE_API_URL;
    axios.defaults.headers.common["Access-Control-Allow-Origin"] = "*";
    axios.defaults.headers.put["Content-Type"] = "application/json";

    function httpGet(url, data, callback) {
        httpRequestWithDataAsParams('get',url,data,callback);
    }

    function httpPost(url, data, callback) {
        httpRequest('post',url,data,callback);
    }

    function httpPut(url, data, callback) {
        httpRequest('put',url,data,callback);
    }

    function httpDelete(url, data, callback) {
        httpRequest('delete',url,data,callback);
    }

    function httpRequest(method,url,data,callback){
        axios({
            method: method,
            url: url,
            data: data
            })
            .catch(function (error) {
                console.log("Show error notification!");
                console.log(error);
                return Promise.reject(error);
            })
            .then(function (e) {
                if(callback)
                    callback(e);
            });
    }

    function httpRequestWithDataAsParams(method,url,data,callback){
        axios({
            method: method,
            url: url,
            params: data
            })
            .catch(function (error) {
                debugger;
                console.log("Show error notification!");
                console.log(error);
                return Promise.reject(error);
            })
            .then(function (e) {
                if(callback)
                    callback(e);
            });
    }

    export function Api() {
        var self = this;
        self.post = httpPost;
        self.get = httpGet;
        self.put = httpPut;
        self.delete = httpDelete;
    }
</script>
