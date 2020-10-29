; Ask for user age

; $ sw_vers -productVersion && system_profiler SPSoftwareDataType
; 10.15.7
; Software:
;
;     System Software Overview:
;
;       System Version: macOS 10.15.7 (19H2)
;       Kernel Version: Darwin 19.6.0
;       Boot Volume: macOS
;       Boot Mode: Normal
;       Computer Name: Panagiotis Hackintosh
;       User Name: Panagiotis Kosmidis (panosru)
;       Secure Virtual Memory: Enabled
;       System Integrity Protection: Disabled
;       Time since boot: 14:37

; assemble
; $ nasm -f macho64 ask_age.asm
; $ ld -macosx_version_min 10.14.0 -lSystem -o ask_age ask_age.o

%define SYSCALL_WRITE 0x2000004
%define SYSCALL_EXIT  0x2000001
%define SYSCALL_READ  0x2000003

section .data
  prompt:   db    "Enter your age: "
  .len:     equ   $ - prompt

  message:  db    "Your age is "
  .len:     equ   $ - message

section .bss
  age: resb 0xFF

section .text
  global _main

_main:
  call _askAge
  call _getInput
  call _printMessage
  call _printAge

  mov rax, SYSCALL_EXIT
  mov rdi, 0
  syscall


_askAge:
  mov rax, SYSCALL_WRITE
  mov rdi, 1
  mov rsi, prompt
  mov rdx, prompt.len
  syscall
  ret

_getInput:
  mov rax, SYSCALL_READ
  mov rdi, 0
  mov rsi, age
  mov rdx, 0xFF
  syscall
  ret

_printMessage:
  mov rax, SYSCALL_WRITE
  mov rdi, 1
  mov rsi, message
  mov rdx, message.len
  syscall
  ret

_printAge:
  mov rax, SYSCALL_WRITE
  mov rdi, 1
  mov rsi, age
  mov rdx, 0xFF
  syscall
  ret
