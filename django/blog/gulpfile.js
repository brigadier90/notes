/* file: gulpfile.js */

var gulp   = require('gulp'),
    connect = require('gulp-connect'),
    sass   = require('gulp-sass');

gulp.task('connect', function() {
	connect.server({
		root: 'public',
		reload: true
	})
});

gulp.task('sass', function() {
	return gulp.src('./sass/**/*.scss')
	.pipe(sass({errLogToConsole: true}))
	.pipe(gulp.dest('./public/css'));
});

gulp.task('livereload', function() {
	gulp.src('./public/**/*')
		.pipe(connect.reload());
});

gulp.task('watch', function() {
	gulp.watch('./sass/**/*.scss', ['sass']);
	gulp.watch('./public/**/*', ['livereload']);

});

gulp.task('default', ['connect', 'watch', 'sass']);