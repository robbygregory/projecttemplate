var gulp = require('gulp');
var config = require('./gulp.config')();
var $ = require('gulp-load-plugins')({ lazy: 'true' });

gulp.task('vet', function () {
	gulp.src([
            config.clientApp + '/**/*.js',
			'./*.js'
	])
        .pipe($.jscs())
        .pipe($.jshint())
        .pipe($.jshint.reporter('jshint-stylish', { verbose: true }));
});

gulp.task('inject', function () {
	//var options = config.getWiredepDefaultOptions();
	var wiredep = require('wiredep').stream;
	return gulp
        .src(config.index)
        .pipe(wiredep(config.getWiredepDefaultOptions()))
        .pipe($.inject(gulp.src(config.js, { read: false }), config.getGulpInjectDefaultOptions()))
        .pipe(gulp.dest(config.client + 'Views/Shared/'));
});

