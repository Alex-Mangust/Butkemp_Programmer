from flask import Flask # Объект


app = Flask(__name__)

@app.route('/') #  GET  - по умолчанию
def main():
    return '<h1>HELLO, WORLD!</h1>'


@app.route('/info') #  GET  - по умолчанию
def info():
    return '<h1>Меня создал Алекс</h1>'

@app.route('/summa/<x>/<y>')
def summa(x, y):
    return f'<h1>{x} + {y} = {int(x) + int(y)}</h1>'


if __name__ == '__main__':
    app.run()