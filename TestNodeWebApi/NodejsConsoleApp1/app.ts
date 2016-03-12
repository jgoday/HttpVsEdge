var http = require("http");
var axios = require("axios");

console.time("req");
axios.get("http://localhost:49253/api/rest/javier")
    .then((res) => {
        console.log(res.data)
        var json = res.data;
        console.log(json.Name);
        console.timeEnd("req");
    })
    .catch((res) => {
        console.log(res);
    }); 