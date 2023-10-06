from flask import Flask
from flask import render_template
from random import randint

app = Flask(__name__)


@app.route('/')
def say_hello():
    context = {
        "title": "Тестовая страница",
        "name": "Алекс",
        'number': randint(1, 6),
        'temp_list': ["Bob", "Ann", "Asya", "Alex", "Eva"]
    }
    return render_template('index.html', **context)


@app.route('/test/')
def say_start():
    return render_template('name.html')


if __name__ == '__main__':
    app.run(debug=True)
