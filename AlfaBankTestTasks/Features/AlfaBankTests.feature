@WebUI
Feature: AlfaBank Tests


Scenario: (1) Login
	Given я сохраняю текст "you UserName" в переменную "userName"
	Given я сохраняю текст "you Passsword" в переменную "password"
		And я развернул веб-страницу на весь экран
		And я перехожу на страницу "Login Page"
		And я ввожу в поле "UserName" веб-страницы значение из переменной "userName"
	When выполнено нажатие на элемент "LoginButton" на веб-странице
	Then адрес активной веб-страницы содержит значение "https://www.mantisbt.org/bugs/login_password_page.php"
		And я обновляю текущую страницу на "LoginPasswordPage"
		And я ввожу в поле "Password" веб-страницы значение из переменной "password"
	When выполнено нажатие на элемент "LoginButton" на веб-странице
	Then адрес активной веб-страницы содержит значение "https://www.mantisbt.org/bugs/my_view_page.php"

Scenario: (2) Login with custom steps
	Given Login on Mantis page with UserName="you UserName" and Password="you Passsword"
	Then адрес активной веб-страницы содержит значение "https://www.mantisbt.org/bugs/my_view_page.php"

Scenario: (3) Create and Check Issue
	Given Login on Mantis page with UserName="you UserName" and Password="you Passsword"
		And я обновляю текущую страницу на "MantisHomePage"
		And выполнено нажатие в блоке "Actions Sidebar" на элемент "Report Issue" на веб-странице
		And я обновляю текущую страницу на "Select Project Page"
		And я выбираю в блоке "Select Project" поле "Dropdown List" веб-страницы текст "Plugin - agileMantis"
		And выполнено нажатие в блоке "Select Project" на элемент "Submit" на веб-странице
	Then адрес активной веб-страницы содержит значение "https://www.mantisbt.org/bugs/bug_report_page.php"
		And я обновляю текущую страницу на "Enter Issue Page"
		And я ввожу в блоке "Enter Issue" в поле "Summary" веб-страницы значение "Summary"
	Then на веб-странице в блоке "Enter Issue" текст элемента "Description Title" содержит значение "Description"
		And я ввожу в блоке "Enter Issue" в поле "Description" веб-страницы значение "Description"
		And выполнено нажатие в блоке "Enter Issue" на элемент "Submit Issue" на веб-странице
		And я жду 7 сек.
		And я обновляю текущую страницу на "View Issue Page"
	Then на веб-странице в блоке "View Issue" текст элемента "Description" содержит значение "Description"
	Then на веб-странице в блоке "View Issue" текст элемента "Summary" содержит значение "Summary"
