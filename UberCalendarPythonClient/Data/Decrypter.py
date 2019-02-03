class Decrypter():


    def decrypt(self, password_to_decrypt):
        alphabet = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789"
        decrypted_password = ""
        for letter in password_to_decrypt:
            if letter in alphabet:
                decrypted_password += alphabet[self.minusTen(alphabet.index(letter))]
                continue
            decrypted_password += letter
            continue
        return decrypted_password

    def minusTen(self, number):
        if (number - 10) < 0:
            return number + 52
        else:
            return number - 10