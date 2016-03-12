var edge = require("edge");

var create_person = edge.func({
	assemblyFile: "../TestEdje/bin/Debug/TestEdje.exe",
	typeName: 'TestEdje.Startup',
	methodName: "CreatePerson"
});

var debug_error = function (error) {
	console.log("Error: " + error);
}

var on_create_person = function (error, result) {
	if (error) {
		debug_error(error);
	}
	else {
		console.log(result.Name);
	}
	
	console.timeEnd("create_person")
}

console.time("create_person");
create_person("Javier", on_create_person);
create_person("Javier", on_create_person);