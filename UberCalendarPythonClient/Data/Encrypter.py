class Encrypter():


    def encrypt(self, password_to_encrypt):
        alphabet = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789"
        encrypted_password = ""
        for letter in password_to_encrypt:
            if letter in alphabet:
                encrypted_password += alphabet[self.plusTen(alphabet.index(letter))]
                continue
            encrypted_password += letter
            continue
        return encrypted_password

    def plusTen(self, number):
        if (number + 10) > 61:
            return number - 52
        else:
            return number + 10










