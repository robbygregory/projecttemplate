module.exports = function () {
	var client = './src/Web/';
	var clientApp = client + 'app/appRoot/';
	var config = {
		client: client,
		index: client + 'Views/Shared/_Layout.cshtml',
		js: [
            clientApp + '**/*.module.js',
			clientApp + '**/*.route.js',
            clientApp + '**/*.js',
            '!' + clientApp + '**/*.spec.js'
		],

		bower: {
			json: require('./bower.json'),
			directory: client + 'bower_components/',
			ignore: '../.'
		}
	};

	config.getWiredepDefaultOptions = function () {
		var options = {
			bowerJson: config.bower.json,
			directory: config.bower.directory,
			ignorePath: config.bower.ignore
		};
		return options;
	};

	config.getGulpInjectDefaultOptions = function () {
		var options = {
			ignorePath: '/src/Web',
			addPrefix: '.',
			addRootSlash: false
		};
		return options;
	};


	return config;
};