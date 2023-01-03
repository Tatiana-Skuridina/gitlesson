from telegram import Update
from telegram.ext import Updater, CommandHandler, CallbackContext
from bot_commands import *

app = Updater("5933770303:AAE_XUo7OCggKXAjSVVrJfyRYX3tbQ-h5mk")

app.dispatcher.add_handler(CommandHandler("hello", hello_command))
app.dispatcher.add_handler(CommandHandler("time", time_command))
app.dispatcher.add_handler(CommandHandler("help", help_command))
app.dispatcher.add_handler(CommandHandler("sum", sum_command))

app.start_polling()
app.idle()