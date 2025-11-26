function getNumbers() {
            const num1 = parseFloat(document.getElementById('num1').value);
            const num2 = parseFloat(document.getElementById('num2').value);
            const resultDiv = document.getElementById('result');

            if (isNaN(num1) || isNaN(num2)) {
                resultDiv.textContent = '2 eded daxil edin';
                resultDiv.classList.add('error');
                return null;
            }

            resultDiv.classList.remove('error');
            return { num1, num2, resultDiv };
        }

        function plus() {
            const data = getNumbers();
            if (!data) return;

            const result = data.num1 + data.num2;
            data.resultDiv.textContent = result.toFixed(2);
        }

        function minus() {
            const data = getNumbers();
            if (!data) return;

            const result = data.num1 - data.num2;
            data.resultDiv.textContent = result.toFixed(2);
        }

        function mult() {
            const data = getNumbers();
            if (!data) return;

            const result = data.num1 * data.num2;
            data.resultDiv.textContent = result.toFixed(2);
        }

        function divide() {
            const data = getNumbers();
            if (!data) return;

            if (data.num2 === 0) {
                data.resultDiv.textContent = 'Sifira bolunmur!';
                data.resultDiv.classList.add('error');
                return;
            }

            const result = data.num1 / data.num2;
            data.resultDiv.textContent = result.toFixed(2);
        }

        document.getElementById('num1').addEventListener('keypress', function(e) {
            if (e.key === 'Enter') {
                plus();
            }
        });

        document.getElementById('num2').addEventListener('keypress', function(e) {
            if (e.key === 'Enter') {
                plus();
            }
        });